using ContratAi.Core.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Core.Entities.Eventos
{
    public class Convidado : BaseEntity
    {
        public Guid EventoId { get; set; }
        public Evento Evento { get; set; }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public bool Confirmado { get; set; }
    }
}
