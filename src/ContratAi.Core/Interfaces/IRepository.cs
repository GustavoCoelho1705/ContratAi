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
        IEnumerable<T> ObterTodos();
        T? ObterPorId(Guid id);
        void Adicionar(T entidade);
        void Atualizar(T entidade);
        void Remover(Guid id);
    }
}
