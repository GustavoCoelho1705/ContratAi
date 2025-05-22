using Microsoft.Extensions.Options;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratAi.Infrastructure.Configurations.Dapper;

public class DbConnectionProvider(string connectionString) : IDisposable
{
    private readonly string _connectionString = connectionString;
    private IDbConnection _connection;
    public IDbConnection GetConnection()
    {
        _connection = new NpgsqlConnection(_connectionString);
        _connection.Open();
        return _connection;
    }
    public void Dispose()
    {
        if(_connection != null)
        {
            _connection.Dispose();
            _connection = null;
        }
    }
}

