using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Core.Enums
{
    public enum CategoriaServicoTipo
    {
        [Description("Fotografia")]
        Fotografia = 1,

        [Description("Buffet")]
        Buffet = 2,

        [Description("Decoração")]
        Decoracao = 3,

        [Description("Som e Iluminação")]
        SomIluminacao = 4,

        [Description("Segurança")]
        Seguranca = 5
    }
}
