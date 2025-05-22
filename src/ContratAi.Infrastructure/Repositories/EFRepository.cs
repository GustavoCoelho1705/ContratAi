using ContratAi.Core.Entities.Shared;
using ContratAi.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ContratAi.Infrastructure.Repositories
{
    public class EFRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected ApplicationDbContext _context;
        protected DbSet<T> _dbSet;

        public EFRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Adicionar(T entidade)
        {
            entidade.DataCriacao = DateTime.UtcNow;
            _dbSet.Add(entidade);

            _context.SaveChanges();
        }

        public void Atualizar(T entidade)
        {
            entidade.DataAtualizacao = DateTime.UtcNow;

            _dbSet.Update(entidade);
            _context.SaveChanges();
        }

        public T? ObterPorId(Guid id) =>
            _dbSet.FirstOrDefault(entidade => entidade.Id == id);

        public IEnumerable<T> ObterTodos() =>
            _dbSet.ToList();

        public void Remover(Guid id)
        {
            _dbSet.Remove(ObterPorId(id));

            _context.SaveChanges();
        }
    }
}
