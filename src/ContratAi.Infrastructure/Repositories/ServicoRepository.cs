using ContratAi.Core.Entities.Servicos;
using ContratAi.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Infrastructure.Repositories
{
    public class ServicoRepository : EFRepository<Servico>, IServicoRepository
    {
        public ServicoRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public async Task<IEnumerable<Servico>> ListarServicoPorCategoria(Guid categoriaId)
            => await _dbSet.Where(s => s.CategoriaId == categoriaId).ToListAsync();
    }
}
