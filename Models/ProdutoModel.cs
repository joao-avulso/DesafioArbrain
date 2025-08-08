using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioArbrain.Enums;

namespace DesafioArbrain.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public CategoriaProduto Categoria { get; set; }

        public ProdutoModel(int id, string nome, CategoriaProduto categoria)
        {
            Id = id;
            Nome = nome;
            Categoria = categoria;
        }
    }
}
