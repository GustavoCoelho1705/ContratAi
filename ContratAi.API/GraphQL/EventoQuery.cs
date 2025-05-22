using ContratAi.Application.Services;
using ContratAi.Core.Entities.Eventos;

namespace ContratAi.API.GraphQL
{
    public class EventoQuery
    {
        public async Task<IEnumerable<Evento>> GetEventos([Service] EventoAppService appService)
            => await appService.ListarTodosEventosAsync();

        public async Task<Evento?> ListarEventoPorId(Guid id, [Service] EventoAppService appService)
            => await appService.ListarEventoPorId(id);
    }
}
