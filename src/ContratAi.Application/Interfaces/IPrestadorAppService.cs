using ContratAi.Core.Entities.Eventos;
using ContratAi.Core.Entities.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Application.Interfaces
{
    public interface IPrestadorAppService
    {
        Task<IEnumerable<PrestadorServico>> ListarTodosPrestadores();
        Task<PrestadorServico?> ListarPrestadorPorId(Guid id);
        Task<IEnumerable<PrestadorServico>> ListarPrestadoresPorCategoria(Guid idCategoria);

    }
}
