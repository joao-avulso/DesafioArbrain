using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioArbrain.Enums
{
    public enum TipoMeta { Monetario, Litros, Unidades }

    public static class TipoMetaExtensions
    {
        public static string ToDescricao(this TipoMeta tipo)
        {
            switch (tipo)
            {
                case TipoMeta.Monetario: return "R$";
                case TipoMeta.Litros: return "L";
                case TipoMeta.Unidades: return "UN";
                default: return tipo.ToString();
            }
        }
    }
}
