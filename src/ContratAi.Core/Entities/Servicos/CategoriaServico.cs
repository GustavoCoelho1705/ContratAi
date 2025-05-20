using ContratAi.Core.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Core.Entities.Servicos
{
    public class CategoriaServico : BaseEntity
    {
        public string Nome {  get; set; }
        public string Descricao { get; set; }

        public ICollection<Servico> Servicos { get; set; } 
    }
}
