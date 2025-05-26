using ContratAi.Application.Interfaces;

namespace ContratAi.API.Extensions.Endpoints
{
    public static class ConvidadoEndpoints
    {
        public static void RegisterConvidadoEndpoints(this WebApplication app)
        {
            var endpointConvidado = app.MapGroup("/Convidado").WithTags("Convidado");

            endpointConvidado.MapGet("/{idEvento}", async (Guid idEvento, IConvidadoAppService convidadoAppService)
                => await convidadoAppService.ListarConvidadoPorIdEvento(idEvento));
        }

    }
}
