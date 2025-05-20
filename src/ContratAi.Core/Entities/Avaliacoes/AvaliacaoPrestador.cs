using ContratAi.Core.Entities.Eventos;
using ContratAi.Core.Entities.Shared;
using ContratAi.Core.Entities.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Core.Entities.Avaliacoes
{
    public class AvaliacaoPrestador : BaseEntity
    {
        public Guid PrestadorServicoId { get; set; }
        public PrestadorServico PrestadorServico { get; set;}

        public Guid EventoId { get; set; }
        public Evento Evento { get; set; }

        public decimal Nota { get; set; }
        public string Comentario { get; set; }
        public DateTime DataAvaliacao { get; set; } = DateTime.UtcNow;
    }
}
