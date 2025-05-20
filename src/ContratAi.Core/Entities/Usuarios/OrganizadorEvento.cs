using ContratAi.Core.Entities.Eventos;
using ContratAi.Core.Entities.Shared;

namespace ContratAi.Core.Entities.Usuarios
{
    public class OrganizadorEvento : BaseEntity
    {
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public string? Empresa { get; set; }
        public string? CNPJ { get; set; }

        public ICollection<Evento> Eventos { get; set; }
    }
}
