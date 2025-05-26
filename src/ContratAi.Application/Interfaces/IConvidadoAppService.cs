using ContratAi.Core.Entities.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Application.Interfaces
{
    public interface IConvidadoAppService
    {
        Task<IEnumerable<Convidado>> ListarConvidadoPorIdEvento(Guid id);
    }
}
