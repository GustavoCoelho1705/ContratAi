using ContratAi.Core.Entities.Shared;
using ContratAi.Core.Enums;

namespace ContratAi.Core.Entities.Usuarios
{
    public class Funcao : BaseEntity
    {
        public TipoFuncao Tipo { get; set; }
        public string Descricao { get; set; }

        public ICollection<UsuarioFuncao> Usuarios { get; set; }
    }
}
