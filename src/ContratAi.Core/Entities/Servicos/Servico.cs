using ContratAi.Core.Entities.Eventos;
using ContratAi.Core.Entities.Shared;

namespace ContratAi.Core.Entities.Servicos
{
    public class Servico : BaseEntity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Guid CategoriaId { get; set; }
        public CategoriaServico Categoria { get; set; }

        public ICollection<ServicoPrestado> Prestadores { get; set; }
        public ICollection<EventoServico> Eventos { get; set; }
    }
}
