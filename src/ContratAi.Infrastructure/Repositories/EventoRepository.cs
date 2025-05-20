using ContratAi.Core.Entities.Eventos;
using ContratAi.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Infrastructure.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public EventoRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Evento>> ListarTodosEventosAsync()
        {
            return await _appDbContext.Eventos.AsNoTracking().ToListAsync();
        }
    }
}
