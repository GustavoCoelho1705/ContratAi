using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Infrastructure.Queries
{
    public static class EventoQueries
    {
        public const string ListarEventoPorId = @"SELECT * FROM ""Eventos"" WHERE ""ID"" = @Id";
    }
}
