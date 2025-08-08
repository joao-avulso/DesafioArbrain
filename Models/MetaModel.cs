using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioArbrain.Enums;

namespace DesafioArbrain.Models
{
    public class MetaModel
    {
        private int _proxId = 1;
        public int Id { get; set; }
        public TipoMeta Tipo { get; set; }
        public VendedorModel Vendedor { get; set; }
        public string VendedorNome => Vendedor?.Nome ?? ""; // Elemento adicionado para possibilitar exibição e ordenação no DataGridView
        public ProdutoModel Produto { get; set; }
        public string ProdutoNome => Produto?.Nome ?? ""; // Elemento adicionado para possibilitar exibição e ordenação no DataGridView
        public decimal Valor { get; set; }
        public Periodicidade Periodicidade { get; set; }
        public bool Ativo { get; set; } = true;

        public MetaModel(int id, TipoMeta tipo, VendedorModel vendedor, ProdutoModel produto, decimal valor, Periodicidade periodicidade, bool ativo)
        {
            _proxId = id;
            Id = id;
            Tipo = tipo;
            Vendedor = vendedor;
            Produto = produto;
            Valor = valor;
            Periodicidade = periodicidade;
            Ativo = ativo;
        }

        public MetaModel(TipoMeta tipo, VendedorModel vendedor, ProdutoModel produto, decimal valor, Periodicidade periodicidade, bool ativo)
        {
            Id = _proxId++;
            Tipo = tipo;
            Vendedor = vendedor;
            Produto = produto;
            Valor = Math.Round(valor, 2);
            Periodicidade = periodicidade;
            Ativo = ativo;
        }

        // Construtor de cópia
        public MetaModel(MetaModel meta)
        {
            Id = meta.Id;
            Tipo = meta.Tipo;
            Vendedor = meta.Vendedor;
            Produto = meta.Produto;
            Valor = Math.Round(meta.Valor, 2);
            Periodicidade = meta.Periodicidade;
            Ativo = meta.Ativo;
        }
    }
}
