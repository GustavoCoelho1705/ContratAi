using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Core.Enums
{
    public enum TipoFuncao
    {
        [Description("Administrador")]
        Admin = 1,

        [Description("Organizador de Eventos")]
        OrganizadorEvento = 2,

        [Description("Prestador de Serviços")]
        PrestadorServico = 3
    }
}
