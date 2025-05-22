using ContratAi.Core.Entities.Eventos;
using ContratAi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Application.Services
{
    public class EventoAppService
    {
        private readonly IEventoRepository _eventoRepository;

        public EventoAppService(IEventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }

        public async Task<IEnumerable<Evento>> ListarTodosEventosAsync()
        {
            return await _eventoRepository.ListarTodosEventosAsync();
        }

        public async Task<Evento?> ListarEventoPorId(Guid id)
        {
            return await _eventoRepository.ListarEventoPorId(id);
        }

        public async Task<Guid> CadastraEvento(Evento evento)
        {
            return await _eventoRepository.CadastraEvento(evento);
        }

        public async Task<Evento> AtualizaEvento(Evento evento)
        {
            return await _eventoRepository.AtualizaEvento(evento);
        }

        public async Task DeletaEvento(Guid idEvento)
        {
            await _eventoRepository.DeletaEvento(idEvento);
        }
    }
}
