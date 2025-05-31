using Application.Feature.UnionMisionLugar.Commands;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.UnionMisionLugar;

namespace Application.UseCase.Interfaces
{
    public interface IUnionMisionLugarUseCase
    {
        Task<GenericResponse> AgregarUnion(AgregarUnionCommand rq);
        Task<GenericResponse> EliminarUnion(EliminarUnionCommand rq);
        Task<GenericResponse> ActualizarUnion(ActualizarUnionCommand rq);
        Task<ListResponse<ListadoUnionResponse>> ListadoUnion();
    }
}
