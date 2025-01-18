using Application.Interfaces.Services;
using Infraestructure.DbContext.Interface;
using Dapper;
using Application.Feature.Usuario.Commands;
using Domain.Entities.Services.Queries.UserEntities;
using Domain.Entities.BaseResponse;


namespace Infraestructure.Repository
{

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
        public Task<UsuarioEntity> ActualizarUsuario()
        {
            throw new NotImplementedException();
        }

        public async Task<UsuarioEntity> AgregarUsuario(IngresarUsuarioCommand rq)
        {


            string _query = @"SELECT * FROM funcUsuarioInsert(@pIdRol, @pIdLugar, @pUsername, @pPassword, @pNombres, @pApellidos, @pSexo::ty_sexo, @pCel, @pEmail)";

            using var connection = _appDbContext.ObtenerConexion(); // Devuelve un IDbConnection válido

            var rs = await connection.QuerySingleOrDefaultAsync<UsuarioEntity>(_query, rq);
            return rs;
        }

        public Task<UsuarioEntity> EliminarUsuario()
        {
            throw new NotImplementedException();
        }

        public async Task<IList<UsuarioEntity>> ListadoUsuario()
        {
            string _query = @"SELECT * FROM func_leer_todos_usuarios()";

            using var connection = _appDbContext.ObtenerConexion(); // Devuelve un IDbConnection válido
            // Ejecuta la consulta y convierte el resultado a un IList<Usuario>
            var rs = (await connection.QueryAsync<UsuarioEntity>(_query)).ToList();
            return rs;
        }
        #endregion
    }
}