using ContratAi.Core.Entities.Eventos;
using ContratAi.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ContratAi.Infrastructure.Repositories
{
    public class ConvidadoRepository : EFRepository<Convidado>, IConvidadoRepository
    {
        public ConvidadoRepository(ApplicationDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<IEnumerable<Convidado>> ObterConvidadosPorIdEvento(Guid eventoId)
            => await _dbSet.Where(c => c.EventoId == eventoId).ToListAsync();
    }
}
