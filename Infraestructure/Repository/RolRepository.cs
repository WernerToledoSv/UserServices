
using Application.Feature.Rol.Commands;
using Application.Feature.Rol.Queries;
using Application.Interfaces.Services;
using Dapper;
using Domain.Entities.Services.Rol;
using Infraestructure.DbContext.Interface;

namespace Infraestructure.Repository
{
    public class RolRepository : IRolService
    {
        #region Atributos
        private readonly IAppDbContext _appDbContext;
        #endregion

        #region Constructor
        public RolRepository(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        #endregion

        #region Commands
        public async Task<RolResponse> ActivarRol(ActivarRolCommand rq)
        {
            string _query = @"SELECT * FROM funcActivarRol(@pId)";
            using var connection = _appDbContext.ObtenerConexion(); // Devuelve un IDbConnection válido

            var rs = await connection.QuerySingleOrDefaultAsync<RolResponse>(_query, rq);
            return rs;
        }

        public async Task<RolResponse> ActualizarRol(ActualizarRolCommand rq)
        {
            string _query = @"SELECT * FROM funcActualizarRol(@pid, @pnombre, @pdescripcion)";
            using var connection = _appDbContext.ObtenerConexion();

            var rs = await connection.QuerySingleOrDefaultAsync<RolResponse>(_query, rq);
            return rs;
        }

        public async Task<RolResponse> AgregarRol(AgregarRolCommand rq)
        {
            string _query = @"SELECT * FROM funccrearrol(@pnombre, @pdescripcion)";
            using var connection = _appDbContext.ObtenerConexion();

            var rs = await connection.QuerySingleOrDefaultAsync<RolResponse>(_query, rq);
            return rs;
        }

        public async Task<RolResponse> EliminarRol(EliminarRolCommand rq)
        {
            string _query = @"SELECT * FROM funcEliminarRol(@pId)";
            using var connection = _appDbContext.ObtenerConexion(); // Devuelve un IDbConnection válido

            var rs = await connection.QuerySingleOrDefaultAsync<RolResponse>(_query, rq);
            return rs;
        }
        #endregion

        #region Queries
        public async Task<IList<RolResponse>> BuscarRolByNombre(BuscarRolByNombreQuery rq)
        {
            string _query = @"SELECT * FROM funcBuscarRolPorNombre(@pNombre)";
            using var connection = _appDbContext.ObtenerConexion();

            var rs = (await connection.QueryAsync<RolResponse>(_query, rq)).ToList();
            return rs;
        }

        public async Task<RolResponse> BuscaRolById(BuscarRolByIdQuery rq)
        {
            string _query = @"SELECT * FROM funcLeerRolPorId(@pId)";
            using var connection = _appDbContext.ObtenerConexion();

            var rs = await connection.QuerySingleOrDefaultAsync<RolResponse>(_query, rq);
            return rs;
        }
        public async Task<IList<RolResponse>> ObtenerRoles()
        {
            string _query = @"SELECT * FROM funcleertodosroles()";
            using var connection = _appDbContext.ObtenerConexion(); // Devuelve un IDbConnection válido

            var rs = (await connection.QueryAsync<RolResponse>(_query)).ToList();
            return rs;
        }
        #endregion
    }
}
