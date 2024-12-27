﻿

using System.Data;
using Application.Configuration.Interfaces;
using Infraestructure.DbContext.Interface;
using Npgsql;

namespace Infraestructure.DbContext
{
    public class AppDbContext : IAppContext
    {
        private IDbConnection _IDbConnection;
        private readonly string _dbpath;
        

        public AppDbContext(IProperties properties)
        {
            _dbpath = properties.DbStringConnection;
        }

        public IDbConnection ObtenerConexion()
        {
            _IDbConnection = new NpgsqlConnection(_dbpath);
            return _IDbConnection;
        }

    }
}
