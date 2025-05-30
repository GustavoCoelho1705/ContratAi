﻿using ContratAi.Core.Entities.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Core.Interfaces
{
    public interface IEventoRepository : IRepository<Evento>
    {
        Task<IEnumerable<Evento>> GetEventosPorIdOrganizador(Guid organizadorId);
    }
}
