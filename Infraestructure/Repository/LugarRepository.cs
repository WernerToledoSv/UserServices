
using Application.Feature.Lugar.Commands;
using Application.Feature.Lugar.Queries;
using Application.Interfaces.Services;
using Dapper;
using Domain.Entities.Services.Lugar;
using Infraestructure.DbContext.Interface;

namespace Infraestructure.Repository
{
    public class LugarRepository : ILugarService
    {
        #region Atributos
        private readonly IAppDbContext _appDbContext;
        #endregion

        #region Constructor
        public LugarRepository(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        #endregion

        #region Queries
        public async Task<IList<LugarResponse>> ObtenerLugar()
        {
            string _query = @"SELECT * FROM funcLeerLugar()";
            using var connection = _appDbContext.ObtenerConexion();

            var rs = (await connection.QueryAsync<LugarResponse>(_query)).ToList();
            return rs;
        }

        public async Task<LugarResponse> BuscarLugarById(BuscarLugarByIdQuery rq)
        {
            string _query = @"SELECT * FROM funcLeerLugarPorId(@pId)";
            using var connection = _appDbContext.ObtenerConexion();
            var rs = await connection.QuerySingleOrDefaultAsync<LugarResponse>(_query, rq);
            return rs;
        }

        public async Task<IList<LugarResponse>> BuscarLugarByNombre(BuscarLugarByNombreQuery rq)
        {
            string _query = @"SELECT * FROM funcLeerLugarPorNombre(@pNombre)";
            using var connection = _appDbContext.ObtenerConexion();

            var rs = (await connection.QueryAsync<LugarResponse>(_query)).ToList();
            return rs;
        }
        #endregion

        #region Commands
        public async Task<LugarResponse> ActivarLugar(ActivarLugarCommand rq)
        {
            string _query = @"SELECT * FROM funcActivarLugar(@pId)";
            using var connection = _appDbContext.ObtenerConexion();
            var rs = await connection.QuerySingleOrDefaultAsync<LugarResponse>(_query, rq);
            return rs;
        }
        public async Task<LugarResponse> ActualizarLugar(ActualizarLugarCommand rq)
        {
            string _query = @"SELECT * FROM funcActualizarLugar(@pId, @pNombre, @pHoraInicio::TIME, @pHoraFin::TIME)";
            using var connection = _appDbContext.ObtenerConexion();
            var rs = await connection.QuerySingleOrDefaultAsync<LugarResponse>(_query, rq);
            return rs;
        }

        public async Task<LugarResponse> AgregarLugar(AgregarLugarCommand rq)
        {
            string _query = @"SELECT * FROM funcagregarlugar(@pNombre, @pHoraInicio::TIME, @pHoraFin::TIME)";
            using var connection = _appDbContext.ObtenerConexion();

            var rs = await connection.QuerySingleOrDefaultAsync<LugarResponse>(_query, rq);
            return rs;
        }

        public async Task<LugarResponse> EliminarLugar(EliminarLugarCommand rq)
        {
            string _query = @"SELECT * FROM funcEliminarLugar(@pId)";
            using var connection = _appDbContext.ObtenerConexion();
            var rs = await connection.QuerySingleOrDefaultAsync<LugarResponse>(_query, rq);
            return rs;
        }
        #endregion
    }
}
