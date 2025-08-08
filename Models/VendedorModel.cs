using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioArbrain.Models
{
    public class VendedorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public VendedorModel(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
