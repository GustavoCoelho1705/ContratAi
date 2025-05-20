using ContratAi.Core.Entities.Servicos;
using ContratAi.Core.Entities.Shared;
using ContratAi.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Core.Entities.Eventos
{
    public class EventoServico : BaseEntity
    {
        public Guid EventoId { get; set; }
        public Evento Evento { get; set; }

        public Guid ServicoPrestadoId {  get; set; }
        public ServicoPrestado ServicoPrestado { get; set; }

        public DateTime DataContratacao { get; set; }
        public int HorasContratadas { get; set; }
        public decimal ValorTotal { get; set; }
        public StatusServicoContratado Status { get; set; }
    }
}
