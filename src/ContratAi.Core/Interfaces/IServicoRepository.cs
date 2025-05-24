using ContratAi.Core.Entities.Servicos;

namespace ContratAi.Core.Interfaces
{
    public interface IServicoRepository : IRepository<Servico>
    {
        Task<IEnumerable<Servico>> ListarServicoPorCategoria(Guid categoriaId);
    }
}
