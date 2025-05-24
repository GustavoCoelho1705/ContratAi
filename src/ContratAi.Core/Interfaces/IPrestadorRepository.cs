using ContratAi.Core.Entities.Usuarios;

namespace ContratAi.Core.Interfaces
{
    public interface IPrestadorRepository : IRepository<PrestadorServico>
    {
        Task<IEnumerable<PrestadorServico>> ListarPrestadoresPorCategoria(Guid categoriaId);
    }
}
