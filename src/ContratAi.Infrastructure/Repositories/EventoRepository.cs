using ContratAi.Core.Entities.Eventos;
using ContratAi.Core.Interfaces;
using ContratAi.Infrastructure.Configurations.Dapper;
using ContratAi.Infrastructure.Queries;
using Dapper;

namespace ContratAi.Infrastructure.Repositories
{
    public class EventoRepository : EFRepository<Evento>, IEventoRepository 
    {
        private readonly DbConnectionProvider _dbProvider;
        public EventoRepository(ApplicationDbContext appDbContext, DbConnectionProvider dbProvider) : base(appDbContext)
        {
            _dbProvider = dbProvider;
        }

        public IEnumerable<Evento> GetEventoPorIdColaborador(Guid colaboradorId)
        {
            var query = EventoQueries.ListarEventoPorIdColaborador;

            using (var connection = _dbProvider.GetConnection())
            {
                return connection.Query<Evento>(query);
            }
        }
    }
}
