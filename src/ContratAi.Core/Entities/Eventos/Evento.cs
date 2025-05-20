using ContratAi.Core.Entities.Shared;
using ContratAi.Core.Entities.Usuarios;
using ContratAi.Core.Enums;

namespace ContratAi.Core.Entities.Eventos
{
    public class Evento : BaseEntity
    {
        public Guid OrganizadorId { get; set; }
        public OrganizadorEvento Organizador { get; set; }

        public string Nome { get; set; }
        public string Descricao {  get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Localizacao { get; set; }
        public int Capacidade { get; set; }
        public StatusServicoContratado Status { get; set; }

        public ICollection<EventoServico> ServicosContratados { get; set; }
        public ICollection<Convidado> Convidados { get; set; }
    }
}
