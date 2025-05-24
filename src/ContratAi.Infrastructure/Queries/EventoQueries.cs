using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Infrastructure.Queries
{
    public static class EventoQueries
    {
        public const string ListarEventoPorIdColaborador = @"SELECT * FROM ""Eventos"" WHERE ""OrganizadorId"" = @Id";

        public const string ListarConvidadosDeUmEvento = @"SELECT * FROM ""Convidados"" WHERE ""EventoId"" = @Id";
    }
}
