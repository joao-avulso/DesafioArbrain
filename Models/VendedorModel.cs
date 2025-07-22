using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioArbrain.Models
{
    public class VendedorModel
    {
        public Guid Id { get; private set; }
        public string Nome { get; set; }

        public VendedorModel(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }
    }
}
