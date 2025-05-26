using ContratAi.Application.Interfaces;
using ContratAi.Core.Entities.Eventos;
using ContratAi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Application.Services
{
    public class ConvidadoAppService : IConvidadoAppService
    {
        private readonly IConvidadoRepository _convidadoRepository;

        public ConvidadoAppService(IConvidadoRepository convidadoRepository)
            => _convidadoRepository = convidadoRepository;

        public async Task<IEnumerable<Convidado>> ListarConvidadoPorIdEvento(Guid id)
            => await _convidadoRepository.ObterConvidadosPorIdEvento(id);
    }
}
