using AutoMapper;
using ContratAi.Application.Input.Evento;
using ContratAi.Core.Entities.Eventos;
using ContratAi.Core.Interfaces;

namespace ContratAi.Application.Services
{
    public class EventoAppService
    {
        private readonly IEventoRepository _eventoRepository;
        private readonly IMapper _mapper;

        public EventoAppService(IEventoRepository eventoRepository, IMapper mapper)
        {   
            _eventoRepository = eventoRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Evento>> ListarTodosEventosAsync()
            => await _eventoRepository.ObterTodos();

        public async Task<Evento?> ListarEventoPorId(Guid id)
            => await _eventoRepository.ObterPorId(id);

        public async Task<IEnumerable<Evento>> ListarEventosPorIdOrganizador(Guid id)
            => await _eventoRepository.GetEventosPorIdOrganizador(id);
        public async Task<Guid> CadastraEvento(AdicionaEventoInput evento)
            => await _eventoRepository.Adicionar(_mapper.Map<AdicionaEventoInput, Evento>(evento));

        public async Task AtualizaEvento(Evento evento)
            => await _eventoRepository.Atualizar(evento);
        
        public async Task DeletaEvento(Guid idEvento)
            => await _eventoRepository.Remover(idEvento);
    }
}
