using ContratAi.Application.Interfaces;

namespace ContratAi.API.Extensions.Endpoints
{
    public static class EventoEndpoints
    {
        public static void RegisterEventoEndpoints(this WebApplication app)
        {
            var endpointsEvento = app.MapGroup("/Evento").WithTags("Evento");

            endpointsEvento.MapGet("/", async (IEventoAppService eventoService)
                => await eventoService.ListarTodosEventosAsync());

            endpointsEvento.MapGet("/organizador/{id}", async (Guid colaboradorId, IEventoAppService eventoService)
                => await eventoService.ListarEventosPorIdOrganizador(colaboradorId));
        }

    }
}
