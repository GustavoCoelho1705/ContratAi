using ContratAi.Application.Dtos.Evento;
using ContratAi.Core.Entities.Eventos;

namespace ContratAi.Application.Interfaces
{
    public interface IEventoAppService
    {
        Task<IEnumerable<Evento>> ListarTodosEventosAsync();
        Task<Evento?> ListarEventoPorId(Guid id);
        Task<IEnumerable<Evento>> ListarEventosPorIdOrganizador(Guid id);
        Task<Guid> CadastraEvento(AdicionaEventoInput evento);
        Task AtualizaEvento(AtualizaEventoInput  evento);
        Task DeletaEvento(Guid idEvento);
    }
}
