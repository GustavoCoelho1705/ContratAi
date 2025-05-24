using ContratAi.Core.Entities.Servicos;
using ContratAi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Application.Services
{
    public class ServicoAppService
    {
        private readonly IServicoRepository _servicoRepository;
        public ServicoAppService(IServicoRepository servicoRepository)
            => _servicoRepository = servicoRepository;

        public async Task<IEnumerable<Servico>> ListarTodosServicos()
            => await _servicoRepository.ObterTodos();

        public async Task<IEnumerable<Servico>> ListarServicosPorCategoria(Guid categoriaId)
            => await _servicoRepository.ListarServicoPorCategoria(categoriaId);
    }
}
