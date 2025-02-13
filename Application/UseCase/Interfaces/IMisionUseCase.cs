
using Application.Feature.Mision.Commands;
using Application.Feature.Mision.Queries;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Mision;

namespace Application.UseCase.Interfaces
{
    public interface IMisionUseCase
    {
        #region Queries
        Task<ListResponse<MisionResponse>> ListadoMision();
        Task<ObjectResponse<MisionResponse>> BuscarMisionByid(BuscarMisionByIdQuery rq);
        Task<ListResponse<MisionResponse>> BuscarMisionByNombre(BuscarMisionByNombreQuery rq);
        #endregion

        #region Commands
        Task<ObjectResponse<MisionResponse>> AgregarMision(AgregarMisionCommand rq);
        Task<ObjectResponse<MisionResponse>> ActualizarMision(ActualizarMisionCommand rq);
        Task<ObjectResponse<MisionResponse>> CancelarMision(CancelarMisionCommand rq);
        Task<ObjectResponse<MisionResponse>> CambiarEstadoMision(CambiarEstadoMisionCommand rq);
        #endregion
    }
}
