using ContratAi.Application.Interfaces;

namespace ContratAi.API.Extensions.Endpoints
{
    public static class ServicoEndpoints
    {
        public static void RegisterServicoEndpoints(this WebApplication app)
        {
            var endpointsServico = app.MapGroup("/servico").WithTags("Servico");

            endpointsServico.MapGet("/", async (IServicoAppService servicoService)
                => await servicoService.ListarTodosServicos());

            endpointsServico.MapGet("/categoria/{id}", async (Guid categoriaId, IServicoAppService servicoAppService)
                => await servicoAppService.ListarServicosPorCategoria(categoriaId));
        }

    }
}
