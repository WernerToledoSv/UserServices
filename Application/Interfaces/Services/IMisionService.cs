
using Application.Feature.Mision.Commands;
using Application.Feature.Mision.Queries;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Mision;

namespace Application.Interfaces.Services
{
    public interface IMisionService
    {
        #region Queries
        Task<IList<MisionResponse>> ListadoMision();
        Task<MisionResponse> BuscarMisionByid(BuscarMisionByIdQuery rq);
        Task<IList<MisionResponse>> BuscarMisionByNombre(BuscarMisionByNombreQuery rq);
        Task<MisionResponse> ActivarMision(ActivarMisionCommand rq);
        #endregion

        #region Commands
        Task<MisionResponse> AgregarMision(AgregarMisionCommand rq);
        Task<MisionResponse> ActualizarMision(ActualizarMisionCommand rq);
        Task<MisionResponse> CancelarMision(CancelarMisionCommand rq);
        Task<MisionResponse> CambiarEstadoMision(CambiarEstadoMisionCommand rq);
        #endregion
    }
}
