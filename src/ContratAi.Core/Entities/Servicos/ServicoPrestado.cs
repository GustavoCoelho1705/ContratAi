using ContratAi.Core.Entities.Shared;
using ContratAi.Core.Entities.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Core.Entities.Servicos
{
    public class ServicoPrestado : BaseEntity
    {
        public Guid PrestadorServicoId { get; set; }
        public PrestadorServico PrestadorServico { get; set; }

        public Guid ServicoId { get; set; }
        public Servico Servico { get; set; }

        public decimal PrecoHora { get; set; }
        public string Descricao { get; set; }
        public int HorasMinimas { get; set; }
    }
}
