
using Application.Feature.Lugar.Commands;
using Application.Feature.Lugar.Queries;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Lugar;

namespace Application.UseCase.Interfaces
{
    public interface ILugarUseCase
    {
        Task<ObjectResponse<LugarResponse>> AgregarLugar(AgregarLugarCommand rq);
        Task<ObjectResponse<LugarResponse>> ActualizarLugar(ActualizarLugarCommand rq);
        Task<ObjectResponse<LugarResponse>> EliminarLugar(EliminarLugarCommand rq);
        Task<ObjectResponse<LugarResponse>> BuscarLugarById(BuscarLugarByIdQuery rq);
        Task<ListResponse<LugarResponse>> BuscarLugarByNombre(BuscarLugarByNombreQuery rq);
        Task<ListResponse<LugarResponse>> ObtenerLugar();
        Task<ObjectResponse<LugarResponse>> ActivarLugar(ActivarLugarCommand rq);
    }
}
