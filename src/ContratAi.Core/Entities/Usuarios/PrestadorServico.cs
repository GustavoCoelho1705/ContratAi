using ContratAi.Core.Entities.Avaliacoes;
using ContratAi.Core.Entities.Servicos;
using ContratAi.Core.Entities.Shared;

namespace ContratAi.Core.Entities.Usuarios;
public class PrestadorServico : BaseEntity
{
    public Guid UsuarioId { get; set; }
    public Usuario Usuario { get; set; }

    public string CNPJ { get; set; }
    public string AreaAtuacao { get; set; }
    public string DescricaoServicos {  get; set; }
    public decimal AvaliacaoMedia { get; set; }

    public ICollection<ServicoPrestado> Servicos { get; set; }
    public ICollection<AvaliacaoPrestador> Avaliacoes { get; set; }
}

