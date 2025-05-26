using ContratAi.Application.Interfaces;

namespace ContratAi.API.Extensions.Endpoints
{
    public static class PrestadorEndpoints
    {
        public static void RegisterPrestadorEndpoints(this WebApplication app)
        {
            var endpointsPrestador = app.MapGroup("/prestador").WithTags("Prestador de Servico");

            endpointsPrestador.MapGet("/", async (IPrestadorAppService prestadorService)
                => await prestadorService.ListarTodosPrestadores());

            endpointsPrestador.MapGet("/{id}", async (Guid id, IPrestadorAppService prestadorService)
                => await prestadorService.ListarPrestadorPorId(id));

            endpointsPrestador.MapGet("/categoria/{id}", async (Guid colaboradorId, IPrestadorAppService prestadorService)
                => await prestadorService.ListarPrestadoresPorCategoria(colaboradorId));
        }

    }
}
