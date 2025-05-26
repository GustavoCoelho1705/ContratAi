using ContratAi.Core.Entities.Eventos;
using ContratAi.Core.Entities.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Application.Interfaces
{
    public interface IServicoAppService
    {
        Task<IEnumerable<Servico>> ListarTodosServicos();
        Task<IEnumerable<Servico>> ListarServicosPorCategoria(Guid categoriaId);
    }
}
