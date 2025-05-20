using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Core.Enums
{
    public enum StatusServicoContratado
    {
        [Description("Cotação")]
        Cotacao = 1,

        [Description("Contratado")]
        Contratado = 2,

        [Description("Em Andamento")]
        EmAndamento = 3,

        [Description("Cancelado")]
        Cancelado = 4,

        [Description("Concluído")]
        Concluido = 5
    }
}
