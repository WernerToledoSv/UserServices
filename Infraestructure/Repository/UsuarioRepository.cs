using Application.Feature.Usuario.Commands;
using Application.Feature.Usuario.Queries;
using Application.Interfaces.Services;
using Dapper;
using Domain.Entities.Services.Usuario;
using Infraestructure.DbContext.Interface;


namespace Infraestructure.Repository
{

    public class UsuarioRepository : IUsuarioService
    {
        #region Atributos
        private readonly IAppDbContext _appDbContext;
        #endregion

        #region Constructor
        public UsuarioRepository(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        #endregion

        #region Commands
        public async Task<UsuarioResponse> ActivarUsuario(ActivarUsuarioCommand rq)
        {
            string _query = @"SELECT * FROM funcActivarUsuario(@pId)";
            using var connection = _appDbContext.ObtenerConexion();

            var rs = await connection.QuerySingleOrDefaultAsync<UsuarioResponse>(_query, rq);
            return rs;
        }

        public async Task<UsuarioResponse> ActualizarUsuario(ActualizarUsuarioCommand rq)
        {
            string _query = @"
            SELECT * FROM funcActualizarUsuario(@pId, @pIdRol, @pIdLugar, @pUsername, @pPassword, @pNombres, @pApellidos, @pSexo::ty_sexo, @pCel, @pEmail)";

            using var connection = _appDbContext.ObtenerConexion();

            var rs = await connection.QuerySingleOrDefaultAsync<UsuarioResponse>(_query, rq);
            return rs;
        }

        public async Task<UsuarioResponse> AgregarUsuario(IngresarUsuarioCommand rq)
        {
            string _query = @"SELECT * FROM funcUsuarioInsert(@pIdRol, @pIdLugar, @pUsername, @pPassword, @pNombres, @pApellidos, @pSexo::ty_sexo, @pCel, @pEmail)";

            using var connection = _appDbContext.ObtenerConexion();

            var rs = await connection.QuerySingleOrDefaultAsync<UsuarioResponse>(_query, rq);
            return rs;
        }

        public async Task<UsuarioResponse> EliminarUsuario(EliminarUsuarioCommand rq)
        {
            string _query = @"SELECT * FROM funcEliminarUsuario(@pId)";
            using var connection = _appDbContext.ObtenerConexion();

            var rs = await connection.QuerySingleOrDefaultAsync<UsuarioResponse>(_query, rq);
            return rs;
        }
        #endregion

        #region Queries

        public async Task<UsuarioResponse> BuscarById(long rq)
        {
            string _query = @"SELECT * FROM funcLeerUsuarioPorId(@pId)";
            using var connection = _appDbContext.ObtenerConexion();

            var rs = await connection.QuerySingleOrDefaultAsync<UsuarioResponse>(_query, rq);
            return rs;
        }

        public async Task<IList<UsuarioResponse>> BuscarUsuarioByNombre(string rq)
        {
            string _query = @"SELECT * FROM funcBuscarUsuarioPorNombres(@pNombres)";
            using var connection = _appDbContext.ObtenerConexion();

            var rs = (await connection.QueryAsync<UsuarioResponse>(_query, rq)).ToList();
            return rs;
        }

        public async Task<IList<UsuarioResponse>> ListadoUsuario()
        {
            string _query = @"SELECT * FROM funcleertodosusuarios()";

            using var connection = _appDbContext.ObtenerConexion();
            var rs = (await connection.QueryAsync<UsuarioResponse>(_query)).ToList();
            return rs;
        }

        public async Task<LoginResponse> LoginUsuario(LoginUsuarioQuery rq)
        {
            string _query = @"SELECT * FROM funcValidarUsuario(@pUsername, @pPassword)";

            using var connection = _appDbContext.ObtenerConexion();

            var rs = await connection.QuerySingleOrDefaultAsync<LoginResponse>(_query, rq);
            return rs;
        }
        #endregion
    }
}