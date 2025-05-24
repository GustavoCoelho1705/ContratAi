using ContratAi.Core.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Core.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> ObterTodos();
        Task<T?> ObterPorId(Guid id);
        Task<Guid> Adicionar(T entidade);
        Task Atualizar(T entidade);
        Task Remover(Guid id);
    }
}
