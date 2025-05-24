using ContratAi.Core.Entities.Usuarios;
using ContratAi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Infrastructure.Repositories
{
    public class PrestadorRepository : EFRepository<PrestadorServico>, IPrestadorRepository
    {
        public PrestadorRepository(ApplicationDbContext appDbContext) : base(appDbContext)
        {
        }

        public Task<IEnumerable<PrestadorServico>> ListarPrestadoresPorCategoria(Guid categoriaId)
        {
            throw new NotImplementedException();
        }
    }
}
