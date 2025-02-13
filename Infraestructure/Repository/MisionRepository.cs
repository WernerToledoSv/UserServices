using Application.Feature.Mision.Commands;
using Application.Feature.Mision.Queries;
using Application.Interfaces.Services;
using Dapper;
using Domain.Entities.Services.Mision;
using Infraestructure.DbContext.Interface;

namespace Infraestructure.Repository
{
    public class MisionRepository : IMisionService
    {
        #region Atributos
        private readonly IAppDbContext _appDbContext;
        #endregion

        #region Constructor
        public MisionRepository(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        #endregion

        #region Commands
        public async Task<MisionResponse> CambiarEstadoMision(CambiarEstadoMisionCommand rq)
        {
            string _query = @"SELECT * FROM funcCambiarEstadoMision(@pId, @pEstado::EstMision)";
            using var connection = _appDbContext.ObtenerConexion();

            var rs = await connection.QuerySingleOrDefaultAsync<MisionResponse>(_query, rq);
            return rs;
        }

        public async Task<MisionResponse> ActualizarMision(ActualizarMisionCommand rq)
        {
            string _query = @"
                    SELECT * FROM funcActualizarMision(
                        @pId,
                        @pNombre, 
                        @pFechaInicio::Date, 
                        @pFechaFin::Date, 
                        @pDescripcion, 
                        @pMision, 
                        @pVision
                    );";
            using var connection = _appDbContext.ObtenerConexion();

            var rs = await connection.QuerySingleOrDefaultAsync<MisionResponse>(_query, rq);
            return rs;
        }

        public async Task<MisionResponse> AgregarMision(AgregarMisionCommand rq)
        {
            string _query = @"
                    SELECT * FROM funcAgregarMision(
                        @pNombre, 
                        @pFechaInicio::Date, 
                        @pFechaFin::Date, 
                        @pDescripcion, 
                        @pMision, 
                        @pVision
                    );";
            using var connection = _appDbContext.ObtenerConexion();

            var rs = await connection.QuerySingleOrDefaultAsync<MisionResponse>(_query, rq);
            return rs;
        }
        public async Task<MisionResponse> CancelarMision(CancelarMisionCommand rq)
        {
            string _query = @"SELECT * FROM funcCancelarMision(@pId)";
            using var connection = _appDbContext.ObtenerConexion();

            var rs = await connection.QuerySingleOrDefaultAsync<MisionResponse>(_query, rq);
            return rs;
        }
        #endregion

        #region Queries
        public async Task<MisionResponse> BuscarMisionByid(BuscarMisionByIdQuery rq)
        {
            string _query = @"SELECT * FROM funcBuscarMisionById(@pId)";
            using var connection = _appDbContext.ObtenerConexion();

            var rs = await connection.QuerySingleOrDefaultAsync<MisionResponse>(_query, rq);
            return rs;
        }

        public async Task<IList<MisionResponse>> ListadoMision()
        {
            string _query = @"SELECT * FROM funcLeerMisiones()";
            using var connection = _appDbContext.ObtenerConexion();

            var rs = (await connection.QueryAsync<MisionResponse>(_query)).ToList();
            return rs;
        }

        public async Task<IList<MisionResponse>> BuscarMisionByNombre(BuscarMisionByNombreQuery rq)
        {
            string _query = @"SELECT * FROM funcBuscarMisionByNombre(@pNombre)";
            using var connection = _appDbContext.ObtenerConexion(); // Devuelve un IDbConnection válido

            var rs = (await connection.QueryAsync<MisionResponse>(_query, rq)).ToList();
            return rs;
        }
        #endregion

    }
}
