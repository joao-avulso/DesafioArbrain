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

namespace DesafioArbrain.Forms
{
    public partial class FormMeta : Form
    {
        private readonly ProdutoService _produtoService = new ProdutoService();

        private readonly VendedorService _vendedorService = new VendedorService();

        public MetaModel novaMeta;


        public FormMeta(MetaModel metaEmEdicao = null)
        {
            // Se uma meta foi passada para edição, atualiza a novaMeta com uma cópia dela
            if (metaEmEdicao != null) { novaMeta = new MetaModel(metaEmEdicao); }

            InitializeComponent();
        }


        // Evento disparado quando o formulário é carregado
        private void FormMeta_Load(object sender, EventArgs e)
        {
            // Configura os DataSources dos ComboBoxes
            comboBox_tipo.DataSource = Enum.GetValues(typeof(TipoMeta))
                .Cast<TipoMeta>()
                .Select(t => t.ToDescricao())
                .ToList();
            comboBox_vendedor.DataSource = _vendedorService.GetAll();
            comboBox_vendedor.DisplayMember = "Nome";
            comboBox_produto.DataSource = _produtoService.GetAll();
            comboBox_produto.DisplayMember = "Nome";
            comboBox_periodo.DataSource = Enum.GetValues(typeof(Periodicidade));

            // Se novaMeta não for nula, preenche os campos do formulário com os dados da meta em edição
            if (novaMeta != null)
            {
                comboBox_tipo.SelectedIndex = (int)novaMeta.Tipo;
                comboBox_vendedor.SelectedItem = novaMeta.Vendedor;
                comboBox_produto.SelectedItem = novaMeta.Produto;
                numericUpDown_valor.Value = novaMeta.Valor;
                comboBox_periodo.SelectedIndex = (int)novaMeta.Periodicidade;
                rjToggleButton_ativo.Checked = novaMeta.Ativo;

                ComboBox_tipo_SelectedIndexChanged(null, null);

                this.Text = "Editar Meta";
                button_excluir.Visible = true;
            }
            else
            {
                button_excluir.Visible = false;
            }
        }


        private void Button_salvar_Click(object sender, EventArgs e)
        {
            TipoMeta novoTipoMeta = (TipoMeta)comboBox_tipo.SelectedIndex;
            VendedorModel novoVendedor = (VendedorModel)comboBox_vendedor.SelectedItem;
            ProdutoModel novoProduto = (ProdutoModel)comboBox_produto.SelectedItem;
            decimal novoValor = (decimal)numericUpDown_valor.Value;
            Periodicidade novaPeriodicidade = (Periodicidade)comboBox_periodo.SelectedIndex;
            bool novaAtivo = rjToggleButton_ativo.Checked;

            // Validação do tipo de meta com o tipo de produto selecionado
            if (novoTipoMeta == TipoMeta.Litros && novoProduto.Categoria == CategoriaProduto.Acessorio)
            {
                MessageBox.Show("Metas em litros só podem ser vinculadas a produtos liquidos.", "Tipo Incompatível", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validação do valor da meta
            if (Math.Round(novoValor, 2) <= 0)
            {
                MessageBox.Show("O valor deve ser um número maior que zero.", "Valor Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (novaMeta != null) // Atualizar a meta existente
            {
                novaMeta.Tipo = novoTipoMeta;
                novaMeta.Vendedor = novoVendedor;
                novaMeta.Produto = novoProduto;
                novaMeta.Valor = novoValor;
                novaMeta.Periodicidade = novaPeriodicidade;
                novaMeta.Ativo = novaAtivo;
            }
            else // Criar uma nova meta
            {
                novaMeta = new MetaModel(novoTipoMeta, novoVendedor, novoProduto, novoValor, novaPeriodicidade, novaAtivo);
            }


            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void Button_excluir_Click(object sender, EventArgs e)
        {
            if (novaMeta != null)
            {
                DialogResult respostaConfirmacao = MessageBox.Show
                (
                    "Tem certeza que deseja excluir esta meta?",
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respostaConfirmacao == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Abort;
                    this.Close();
                }
            }
        }


        // Evento disparado quando o tipo de meta é alterado
        // Atualiza o texto do label e o número de casas decimais do NumericUpDown
        private void ComboBox_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoMeta tipoSelecionado = (TipoMeta)comboBox_tipo.SelectedIndex;
            label_tipoValor.Text = tipoSelecionado.ToDescricao();
            numericUpDown_valor.DecimalPlaces = tipoSelecionado == TipoMeta.Monetario ? 2 : 0;
        }


        // Evento para captura de teclas de atalho
        private void FormMeta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                button_salvar.PerformClick();
                e.Handled = true;
            }
        }


        // Evento para tratamento de numeros e pontuação no NumericUpDown de valor
        private void NumericUpDown_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Substitui ponto por vírgula
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            // Impedir mais de duas casas decimais
            if (numericUpDown_valor.DecimalPlaces > 0 && numericUpDown_valor.Text.Contains(','))
            {
                string[] partes = numericUpDown_valor.Text.Split(',');
                if (partes.Length > 1 && partes[1].Length >= numericUpDown_valor.DecimalPlaces)
                {
                    e.Handled = true;
                }
            }

            // Permitir backspace
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                return;
            }

            // Impedir vírgula em valores inteiros
            if (numericUpDown_valor.DecimalPlaces == 0 && (e.KeyChar == ',' || e.KeyChar == '.'))
            {
                e.Handled = true;
                return;
            }

            // Impedir mais de uma vírgula
            if ((e.KeyChar == ',' || e.KeyChar == '.') && numericUpDown_valor.Text.Contains(','))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
