using AutoMapper;
using ContratAi.Application.Dtos.Evento;
using ContratAi.Core.Entities.Eventos;

namespace ContratAi.Application.Mappings
{
    public class EventoMappingProfile : Profile
    {
        public EventoMappingProfile()
        {
            CreateMap<AdicionaEventoInput, Evento>();
            CreateMap<AtualizaEventoInput, Evento>();
        }
    }
}
