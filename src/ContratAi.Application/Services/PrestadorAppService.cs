using AutoMapper;
using ContratAi.Core.Entities.Usuarios;
using ContratAi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Application.Services
{
    public class PrestadorAppService
    {
        private readonly IPrestadorRepository _prestadorRepository;
        public PrestadorAppService(IPrestadorRepository prestadorRepository)
        {
            _prestadorRepository = prestadorRepository;
        }

        public async Task<IEnumerable<PrestadorServico>> ListarTodosPrestadores()
            => await _prestadorRepository.ObterTodos();

        public async Task<PrestadorServico?> ListarPrestadorPorId(Guid id)
            => await _prestadorRepository.ObterPorId(id);

        public async Task<IEnumerable<PrestadorServico>> ListarPrestadoresPorCategoria(Guid idCategoria)
            => await _prestadorRepository.ListarPrestadoresPorCategoria(idCategoria);
    }
}
