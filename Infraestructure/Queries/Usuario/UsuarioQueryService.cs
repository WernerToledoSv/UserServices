using Application.Interfaces.Services;
using Infraestructure.DbContext.Interface;
using Dapper;

namespace Infraestructure.Queries.Usuario
{
    using System;
    using Domain.Entities.Services.Queries;
    using Infraestructure.DbContext;

    public class UsuarioQueryService : IUsuarioService
    {
        #region Atributos
        private readonly IAppDbContext _appDbContext;
        #endregion

        #region Constructor
        public UsuarioQueryService(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        #endregion

        #region Metodos
        public Task<Usuario> ActualizarUsuario()
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> AgregarUsuario()
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> EliminarUsuario()
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Usuario>> ListadoUsuario()
        {
            string _query = @"SELECT * FROM func_leer_todos_usuarios()";
            
            using var connection = _appDbContext.ObtenerConexion(); // Devuelve un IDbConnection válido
            // Ejecuta la consulta y convierte el resultado a un IList<Usuario>
            var rs = (await connection.QueryAsync<Usuario>(_query)).ToList(); 
            return rs; 
        }
        #endregion
    }
}