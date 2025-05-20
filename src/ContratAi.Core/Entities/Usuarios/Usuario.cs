using ContratAi.Core.Entities.Shared;

namespace ContratAi.Core.Entities.Usuarios
{
    public class Usuario : BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string SenhaHash { get; set; }
        public string Telefone { get; set; }

        public ICollection<UsuarioFuncao> Funcoes { get; set; }
        public PrestadorServico? PrestadorServico { get; set; }
        public OrganizadorEvento? OrganizadorEvento { get; set; }
    }
}
