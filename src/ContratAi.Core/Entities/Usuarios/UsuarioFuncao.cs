using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Core.Entities.Usuarios
{
    public class UsuarioFuncao
    {
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public Guid FuncaoId { get; set; }
        public Funcao Funcao { get; set; }
    }
}
