
using Application.Feature.UnionMisionLugar.Commands;
using Application.Interfaces.Services;
using Dapper;
using Domain.Entities.Services.UnionMisionLugar;
using Domain.Entities.Services.Usuario;
using Infraestructure.DbContext.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Infraestructure.Repository
{
    public class UnionRepository : IUnionMisionLugarService
    {
        #region Atributos
        private readonly IAppDbContext _appDbContext;

        #endregion

        #region Controller
        public UnionRepository(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        #endregion

        #region Command
        public async Task<bool> ActualizarUnion(ActualizarUnionCommand rq)
        {
            string _query = @"SELECT funcActualizarunion(@pid, @pidLugar, @pidMision)";

            using var connection = _appDbContext.ObtenerConexion();

            var rs = await connection.ExecuteAsync(_query, rq);
            if (rs == 1)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> AgregarUnion(AgregarUnionCommand rq)
        {
            
            string _query = @"SELECT funcAgregarunion(@pidLugar, @pidMision)";

            try
            {
                using var connection = _appDbContext.ObtenerConexion();

                var rs = await connection.ExecuteAsync(_query, rq);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> EliminarUnion(EliminarUnionCommand rq)
        {
            string _query = @"SELECT funceliminarunion(@pid)";

            try
            {
                using var connection = _appDbContext.ObtenerConexion();

                var rs = await connection.ExecuteAsync(_query, rq);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<IList<ListadoUnionResponse>> ListadoUnion()
        {
            string query = @"
                               SELECT u.id, m.nombre as mision, m.fechainicio as fechainiciomision, m.fechafin as fechafinmision, l.fecha as fechalugar, m.descripcion, 
                                l.nombre as lugar, l.horainicio, l.horafin   
                            FROM unionmisionlugar u
                            JOIN mision m ON u.idmision = m.id 
                            JOIN lugar l ON u.idlugar = l.id;";
            
            using var connection = _appDbContext.ObtenerConexion();
            var rs = (await connection.QueryAsync<ListadoUnionResponse>(query)).ToList();
            return rs;
        }
        #endregion
    }
}
