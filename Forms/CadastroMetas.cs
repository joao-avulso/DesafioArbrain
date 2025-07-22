using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesafioArbrain.Enums;
using DesafioArbrain.Models;
using DesafioArbrain.Service;
using DesafioArbrain.Service.Desfazer;
using DesafioArbrain.Utils;

namespace DesafioArbrain.Forms
{
    public partial class CadastroMetas : Form
    {
        // Listas de vendedores e produtos para realizar os cadastros de metas.
        // Essas listas estão sendo usadas para simular dados, em um cenário real, esses dados viriam de um banco de dados ou API.
        private static readonly List<VendedorModel> _vendedores = new List<VendedorModel>
        {
            new VendedorModel("Bar do Zeca"),
            new VendedorModel("Chopp & Companhia LTDA"),
            new VendedorModel("Boa Gelada"),
        };

        private static readonly List<ProdutoModel> _produtos = new List<ProdutoModel>
        {
            new ProdutoModel("Barril", CategoriaProduto.Barril),
            new ProdutoModel("Garrafa/Lata", CategoriaProduto.GarrafaLata),
            new ProdutoModel("Abridor de Garrafa", CategoriaProduto.Acessorio)
        };

        private static readonly MetaService _metaService = new MetaService();

        private static readonly DesfazerManager _desfazerManager = new DesfazerManager();

        private static readonly string _placeholderTextFiltro = "Tipo, Vendedor, Produto, Periodo.";

        private static readonly Image imgAtivo = Properties.Resources.Ativo;

        private static readonly Image imgInativo = Properties.Resources.Inativo;

        public CadastroMetas()
        {
            InitializeComponent();

            // Gerar metas aleatórias para simulação
            for (int i = 0; i < 10; i++)
            {
                TipoMeta tipo = (TipoMeta)(i % 3);
                VendedorModel vendedor = _vendedores[i % _vendedores.Count];
                ProdutoModel produto = _produtos[i % _produtos.Count];
                decimal valor = (i + 1) * 100;
                Periodicidade periodicidade = (Periodicidade)(i % 3);
                bool ativo = i % 2 == 0;
                MetaModel meta = new MetaModel(tipo, vendedor, produto, valor, periodicidade, ativo);

                _metaService.AddMeta(meta);
            }
        }


        // Função que é chamada quando o formulário é carregado
        private void CadastroMetas_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = _metaService.Metas;

            // Configuração das colunas do DataGridView
            dataGridView.Columns["Id"].FillWeight = 30;
            dataGridView.Columns["Tipo"].FillWeight = 30;
            dataGridView.Columns["Produto"].Visible = false;
            dataGridView.Columns["Vendedor"].Visible = false;
            dataGridView.Columns["VendedorNome"].HeaderText = "Vendedor";
            dataGridView.Columns["ProdutoNome"].HeaderText = "Produto";
            dataGridView.Columns["Valor"].HeaderText = "Valor/Quantidade";
            dataGridView.Columns["Ativo"].Visible = false;

            // Coluna para exibir imagens de ativo/inativo
            var colunaAtivoImg = new DataGridViewImageColumn
            {
                Name = "AtivoImg",
                HeaderText = "Ativo?",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                FillWeight = 30
            };
            dataGridView.Columns.Add(colunaAtivoImg);

            // Definição de eventos para o botão de desfazer
            void funcaoAcaoDesfazer()
            {
                button_desfazer.Enabled = _desfazerManager.PodeDesfazer();
                label_desfazer.Visible = _desfazerManager.PodeDesfazer();
                label_desfazer.Text = _desfazerManager.PodeDesfazer()? $"Desfazer: {_desfazerManager.GetUltimaAcao().Tipo}" : String.Empty;
            }

            _desfazerManager.AcaoRegistrada += (s, a) => { funcaoAcaoDesfazer(); };
            _desfazerManager.AcaoDesfeita += (s, a) => { funcaoAcaoDesfazer(); };

            //Check_Filtro_Inativos();
            Filtrar_Metas(String.Empty, rjToggleButton_ativo.Checked);
        }


        // Atualiza o label que exibe a quantidade de registros visíveis
        private void Update_ContRegistros()
        {
            int totalRegistros = _metaService.Metas.Count;
            int registrosVisiveis = dataGridView.Rows.Count;
            label_countReg.Text = $"{registrosVisiveis} de {totalRegistros} registros.";
        }


        // Filtra as metas com base no nome do vendedor, nome do produto, tipo, periodicidade e o toggle de ativo/inativo
        private void Filtrar_Metas(string filtro, bool filtrarAtivos)
        {
            List<MetaModel> metas;

            // Se o filtro estiver vazio, exibe todas as metas
            if (filtro == _placeholderTextFiltro || string.IsNullOrWhiteSpace(filtro))
            {
                metas = _metaService.Metas.ToList();
            }
            else // Caso contrário, filtra as metas com base no filtro fornecido
            {
                filtro = filtro.ToLower().Trim();
                metas = _metaService.Metas
                .Where(m => m.Vendedor.Nome.ToLower().Contains(filtro) ||
                            m.Produto.Nome.ToLower().Contains(filtro) ||
                            m.Tipo.ToDescricao().ToLower().Contains(filtro) ||
                            m.Periodicidade.ToString().ToLower().Contains(filtro))
                .ToList();
            }

            // Se o toggle de ativo estiver marcado, filtra apenas as metas ativas
            if (filtrarAtivos) { metas = metas.Where(m => m.Ativo).ToList(); }

            dataGridView.DataSource = new SortableBindingList<MetaModel>(metas);
        }


        private void Button_adicionar_Click(object sender, EventArgs e)
        {
            FormMeta formMeta = new FormMeta(_vendedores, _produtos);
            if (formMeta.ShowDialog() == DialogResult.OK)
            {
                _metaService.AddMeta(formMeta.novaMeta);
                AcaoDesfazer acaoAdicionar = new AcaoDesfazer("Adicionar Meta", () => { _metaService.DeleteMeta(formMeta.novaMeta); });
                _desfazerManager.RegistrarAcao(acaoAdicionar);
                Filtrar_Metas(textBox_filtro.Text, rjToggleButton_ativo.Checked);
            }
        }


        private void Button_excluir_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DialogResult respostaConfirmacao = MessageBox.Show
                (
                    "Tem certeza que deseja excluir a(s) meta(s) selecionada(s)?",
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respostaConfirmacao == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView.SelectedRows)
                    {
                        if (row.DataBoundItem is MetaModel meta)
                        {
                            _metaService.DeleteMeta(meta);
                            AcaoDesfazer acaoExcluir = new AcaoDesfazer("Excluir Meta", () => { _metaService.AddMeta(meta); });
                            _desfazerManager.RegistrarAcao(acaoExcluir);
                            dataGridView.Rows.Remove(row);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma meta para excluir.", "Seleção Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void Button_editar_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dataGridView.SelectedRows[0]; // Edita apenas a primeira linha selecionada
                if (linhaSelecionada.DataBoundItem is MetaModel meta)
                {
                    MetaModel metaAnterior = new MetaModel(meta); // Cria uma cópia da meta original para registro da ação de desfazer

                    FormMeta formMeta = new FormMeta(_vendedores, _produtos, meta);

                    DialogResult resultEdicao = formMeta.ShowDialog();

                    if (resultEdicao == DialogResult.OK) // Caso o usuário tenha salvado a edição
                    {
                        _metaService.UpdateMeta(formMeta.novaMeta);
                        AcaoDesfazer acaoEditar = new AcaoDesfazer("Editar Meta", () => { _metaService.UpdateMeta(metaAnterior); });
                        _desfazerManager.RegistrarAcao(acaoEditar);
                        Filtrar_Metas(textBox_filtro.Text, rjToggleButton_ativo.Checked);
                    }
                    else if (resultEdicao == DialogResult.Abort) // Caso o usuário tenha excluído a meta
                    {
                        _metaService.DeleteMeta(meta);
                        AcaoDesfazer acaoExcluir = new AcaoDesfazer("Excluir Meta", () => { _metaService.AddMeta(metaAnterior); });
                        _desfazerManager.RegistrarAcao(acaoExcluir);
                        dataGridView.Rows.Remove(linhaSelecionada);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma meta para editar.", "Seleção Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void Button_duplicar_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DialogResult respostaConfirmacao = MessageBox.Show
                (
                    "Tem certeza que deseja duplicar a(s) meta(s) selecionada(s)?",
                    "Confirmação de Duplicação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respostaConfirmacao == DialogResult.Yes)
                {
                    foreach (DataGridViewRow linhaSelecionada in dataGridView.SelectedRows)
                    {
                        if (linhaSelecionada.DataBoundItem is MetaModel meta)
                        {
                            MetaModel novaMeta = new MetaModel(meta.Tipo, meta.Vendedor, meta.Produto, meta.Valor, meta.Periodicidade, meta.Ativo);
                            _metaService.AddMeta(novaMeta);
                            AcaoDesfazer acaoDuplicar = new AcaoDesfazer("Duplicar Meta", () => { _metaService.DeleteMeta(novaMeta); });
                            _desfazerManager.RegistrarAcao(acaoDuplicar);
                            Filtrar_Metas(textBox_filtro.Text, rjToggleButton_ativo.Checked);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma meta para duplicar.", "Seleção Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void Button_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Button_limpar_filtro_Click(object sender, EventArgs e)
        {
            textBox_filtro.Text = _placeholderTextFiltro;
            textBox_filtro.ForeColor = Color.Gray;
            Filtrar_Metas(String.Empty, rjToggleButton_ativo.Checked);
        }


        private void Button_desfazer_Click(object sender, EventArgs e)
        {
            if (_desfazerManager.PodeDesfazer())
            {
                _desfazerManager.DesfazerUltimaAcao();
                Filtrar_Metas(textBox_filtro.Text, rjToggleButton_ativo.Checked);
            }
            else
            {
                MessageBox.Show("Não há ações para desfazer.", "Nenhuma Ação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void TextBox_filtro_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBox_filtro.Text.Trim().ToLower();

            Filtrar_Metas(filtro, rjToggleButton_ativo.Checked);
        }


        // Evento para limpar o filtro quando o usuário clica no TextBox
        private void TextBox_filtro_Enter(object sender, EventArgs e)
        {
            if (textBox_filtro.Text == _placeholderTextFiltro)
            {
                textBox_filtro.Text = string.Empty;
                textBox_filtro.ForeColor = SystemColors.WindowText;
            }
        }


        // Evento para restaurar o placeholder do filtro quando o usuário sai do TextBox sem digitar nada
        private void TextBox_filtro_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_filtro.Text))
            {
                textBox_filtro.Text = _placeholderTextFiltro;
                textBox_filtro.ForeColor = Color.Gray;
                Filtrar_Metas(String.Empty, rjToggleButton_ativo.Checked);
            }
        }


        // Evento que é disparado quando a seleção do DataGridView é alterada
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                button_editar.Enabled = true;
                button_excluir.Enabled = true;
                button_duplicar.Enabled = true;
            }
            else
            {
                button_editar.Enabled = false;
                button_excluir.Enabled = false;
                button_duplicar.Enabled = false;
            }
        }


        // Evento que formata as células do DataGridView para exibir os valores de forma adequada
        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "Tipo")
            {
                if (dataGridView.Rows[e.RowIndex].DataBoundItem is MetaModel meta)
                {
                    e.Value = meta.Tipo.ToDescricao();
                    e.FormattingApplied = true;
                }
            }
            else if (dataGridView.Columns[e.ColumnIndex].Name == "Valor")
            {
                if (dataGridView.Rows[e.RowIndex].DataBoundItem is MetaModel meta)
                {
                    if (meta.Tipo == TipoMeta.Monetario)
                    {
                        e.Value = $"R$ {meta.Valor:N2}";
                    }
                    else if (meta.Tipo == TipoMeta.Unidades)
                    {
                        e.Value = $"{meta.Valor:N0} UN";
                    }
                    else
                    {
                        e.Value = $"{meta.Valor:N0} L";
                    }
                    e.FormattingApplied = true;
                }
            }
            else if (dataGridView.Columns[e.ColumnIndex].Name == "AtivoImg")
            {
                if (dataGridView.Rows[e.RowIndex].DataBoundItem is MetaModel meta)
                {
                    e.Value = meta.Ativo ? imgAtivo : imgInativo;
                    e.FormattingApplied = true;
                }
            }
        }


        private void DataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Update_ContRegistros();
        }


        private void DataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Update_ContRegistros();
        }


        // Evento para captura de teclas de atalho
        private void CadastroMetas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                button_adicionar.PerformClick();
                e.Handled = true;
            }
        }

        private void RjToggleButton_ativo_CheckedChanged(object sender, EventArgs e)
        {
            // Se o filtro estiver vazio, apenas filtra por ativo/inativo
            if (textBox_filtro.Text == _placeholderTextFiltro || string.IsNullOrWhiteSpace(textBox_filtro.Text))
            {
                Filtrar_Metas(String.Empty, rjToggleButton_ativo.Checked);
            }
            else // Se houver um filtro aplicado, mantém o filtro e aplica a condição de ativo/inativo
            {
                Filtrar_Metas(textBox_filtro.Text, rjToggleButton_ativo.Checked);
            }
        }
    }
}
