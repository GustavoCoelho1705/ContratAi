using ContratAi.Application.Dtos.Evento;
using ContratAi.Application.Services;

namespace ContratAi.API.GraphQL
{
    public class EventoMutation
    {
        public async Task<Guid> AdicionaEvento(AdicionaEventoInput cadastraEvento, [Service] EventoAppService appService)
            => await appService.CadastraEvento(cadastraEvento);

    }
}
