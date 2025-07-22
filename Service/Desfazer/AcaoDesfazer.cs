using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioArbrain.Service.Desfazer
{
    public class AcaoDesfazer
    {
        public string Tipo { get; private set; }

        public Action Acao { get; private set; }

        public AcaoDesfazer(string tipo, Action acao) 
        {
            Tipo = tipo ?? throw new ArgumentNullException(nameof(tipo));
            Acao = acao ?? throw new ArgumentNullException(nameof(acao));
        }
    }
}
