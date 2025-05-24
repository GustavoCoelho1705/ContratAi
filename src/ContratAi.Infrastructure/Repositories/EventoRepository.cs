using ContratAi.Core.Entities.Eventos;
using ContratAi.Core.Interfaces;
using ContratAi.Infrastructure.Configurations.Dapper;
using ContratAi.Infrastructure.Queries;
using Dapper;
using Microsoft.EntityFrameworkCore;

namespace ContratAi.Infrastructure.Repositories
{
    public class EventoRepository : EFRepository<Evento>, IEventoRepository 
    {
        private readonly DbConnectionProvider _dbProvider;
        public EventoRepository(ApplicationDbContext appDbContext, DbConnectionProvider dbProvider) : base(appDbContext)
        {
            _dbProvider = dbProvider;
        }

        public async Task<IEnumerable<Evento>> GetEventosPorIdOrganizador(Guid organizadorId)
            => await _dbSet.Where(e => e.OrganizadorId == organizadorId).ToListAsync();
    }
}
