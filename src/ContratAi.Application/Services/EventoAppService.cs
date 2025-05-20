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
    }
}
