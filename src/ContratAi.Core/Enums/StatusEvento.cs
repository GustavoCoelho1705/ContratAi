using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Core.Enums
{
    public enum StatusEvento
    {
        [Description("Em Planejamento")]
        Planejamento = 1,

        [Description("Ativo")]
        Ativo = 2,

        [Description("Cancelado")]
        Cancelado = 3,

        [Description("Concluído")]
        Concluido = 4
    }
}
