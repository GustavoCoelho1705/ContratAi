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

        public async Task<Guid> Adicionar(T entidade)
        {
            entidade.DataCriacao = DateTime.UtcNow;

            await _dbSet.AddAsync(entidade);
            await _context.SaveChangesAsync();

            return entidade.Id;
        }

        public async Task Atualizar(T entidade)
        {
            entidade.DataAtualizacao = DateTime.UtcNow;

            _dbSet.Update(entidade);
            await _context.SaveChangesAsync();
        }

        public async Task<T?> ObterPorId(Guid id) =>
            await _dbSet.FirstOrDefaultAsync(entidade => entidade.Id == id);

        public async Task<IEnumerable<T>> ObterTodos() =>
            await _dbSet.ToListAsync();

        public async Task Remover(Guid id)
        {
            _dbSet.Remove(await ObterPorId(id));

            await _context.SaveChangesAsync();
        }
    }
}
