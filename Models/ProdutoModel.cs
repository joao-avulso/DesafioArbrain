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
        public Guid Id { get; private set; }
        public string Nome { get; set; }
        public CategoriaProduto Categoria { get; set; }

        public ProdutoModel(string nome, CategoriaProduto categoria)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Categoria = categoria;
        }
    }
}
