using Application.Interfaces.Services;
using Infraestructure.DbContext.Interface;
using Dapper;
using Application.Feature.Usuario.Commands;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;


namespace Infraestructure.Repository
{

    public class UsuarioService : IUsuarioService
    {
        #region Atributos
        private readonly IAppDbContext _appDbContext;
        #endregion

        #region Constructor
        public UsuarioService(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        #endregion

        #region Metodos
        public Task<UsuarioResponse> ActualizarUsuario()
        {
            throw new NotImplementedException();
        }

        public async Task<UsuarioResponse> AgregarUsuario(IngresarUsuarioCommand rq)
        {


            string _query = @"SELECT * FROM funcUsuarioInsert(@pIdRol, @pIdLugar, @pUsername, @pPassword, @pNombres, @pApellidos, @pSexo::ty_sexo, @pCel, @pEmail)";

            using var connection = _appDbContext.ObtenerConexion(); // Devuelve un IDbConnection válido

            var rs = await connection.QuerySingleOrDefaultAsync<UsuarioResponse>(_query, rq);
            return rs;
        }

        public Task<UsuarioResponse> EliminarUsuario()
        {
            throw new NotImplementedException();
        }

        public async Task<IList<UsuarioResponse>> ListadoUsuario()
        {
            string _query = @"SELECT * FROM funcleertodosusuarios()";

            using var connection = _appDbContext.ObtenerConexion(); // Devuelve un IDbConnection válido
            // Ejecuta la consulta y convierte el resultado a un IList<Usuario>
            var rs = (await connection.QueryAsync<UsuarioResponse>(_query)).ToList();
            return rs;
        }
        #endregion
    }
}