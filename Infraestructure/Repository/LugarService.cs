
using Application.Feature.Lugar.Commands;
using Application.Interfaces.Services;
using Dapper;
using Domain.Entities.Services.Lugar;
using Domain.Entities.Services.Rol;
using Infraestructure.DbContext.Interface;

namespace Infraestructure.Repository
{
    public class LugarService : ILugarService
    {
        private readonly IAppDbContext _appDbContext;

        public LugarService(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<LugarResponse> ActivarLugar(ActivarLugarCommand rq)
        {
            string _query = @"SELECT * FROM funcActivarLugar(@pId)";
            using var connection = _appDbContext.ObtenerConexion();
            var rs = await connection.QuerySingleOrDefaultAsync<LugarResponse>(_query, rq);
            return rs;
        }

        public async Task<LugarResponse> ActualizarLugar(ActualizarLugarCommand rq)
        {
            string _query = @"SELECT * FROM funcActualizarLugar(@pId, @pNombre, @pHoraInicio::TIME, @pHoraFin::TIME, @pFecha::DATE)";
            using var connection = _appDbContext.ObtenerConexion();
            var rs = await connection.QuerySingleOrDefaultAsync<LugarResponse>(_query, rq);
            return rs;
        }

        public async Task<LugarResponse> AgregarLugar(AgregarLugarCommand rq)
        {
            string _query = @"SELECT * FROM funcagregarlugar(@pNombre, @pHoraInicio::TIME, @pHoraFin::TIME, @pFecha::DATE)";
            using var connection = _appDbContext.ObtenerConexion();

            var rs = await connection.QuerySingleOrDefaultAsync<LugarResponse>(_query, rq);
            return rs;
        }

        public Task<LugarResponse> BuscarLugarById()
        {
            throw new NotImplementedException();
        }

        public Task<IList<LugarResponse>> BuscarLugarByNombre()
        {
            throw new NotImplementedException();
        }

        public async Task<LugarResponse> EliminarLugar(EliminarLugarCommand rq)
        {
            string _query = @"SELECT * FROM funcEliminarLugar(@pId)";
            using var connection = _appDbContext.ObtenerConexion();
            var rs = await connection.QuerySingleOrDefaultAsync<LugarResponse>(_query, rq);
            return rs;
        }

        public async Task<IList<LugarResponse>> ObtenerLugar()
        {
            string _query = @"SELECT * FROM funcLeerLugar()";
            using var connection = _appDbContext.ObtenerConexion();

            var rs = (await connection.QueryAsync<LugarResponse>(_query)).ToList();
            return rs;
        }
    }
}
