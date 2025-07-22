using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesafioArbrain.Models;
using DesafioArbrain.Utils;

namespace DesafioArbrain.Service
{
    public class MetaService
    {

        // SortableBindingList é uma lista que suporta ordenação quando vinculada a um DataGridView.
        // Simula uma lista obtida através de um banco de dados.
        public SortableBindingList<MetaModel> Metas { get; private set; }

        public MetaService()
        {
            Metas = new SortableBindingList<MetaModel>();
        }

        public void AddMeta(MetaModel meta)
        {
            if (meta == null)
            {
                MessageBox.Show("Meta inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Metas.Add(meta);
            }
        }

        public void DeleteMeta(MetaModel meta)
        {
            if (meta == null)
            {
                MessageBox.Show("Meta inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Metas.Remove(meta);
            }
        }

        public void UpdateMeta(MetaModel metaEditada)
        {
            MetaModel metaAtual = Metas.FirstOrDefault(m => m.Id == metaEditada.Id);
            if (metaAtual != null)
            {
                metaAtual.Tipo = metaEditada.Tipo;
                metaAtual.Vendedor = metaEditada.Vendedor;
                metaAtual.Produto = metaEditada.Produto;
                metaAtual.Valor = metaEditada.Valor;
                metaAtual.Periodicidade = metaEditada.Periodicidade;
                metaAtual.Ativo = metaEditada.Ativo;
                Metas.ResetBindings();
            }
            else
            {
                MessageBox.Show("Meta não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
