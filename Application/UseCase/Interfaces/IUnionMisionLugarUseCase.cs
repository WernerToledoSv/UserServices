using Application.Feature.UnionMisionLugar.Commands;
using Domain.Entities.BaseResponse;

namespace Application.UseCase.Interfaces
{
    public interface IUnionMisionLugarUseCase
    {
        Task<GenericResponse> AgregarUnion(AgregarUnionCommand rq);
        Task<GenericResponse> EliminarUnion(EliminarUnionCommand rq);
        Task<GenericResponse> ActualizarUnion(ActualizarUnionCommand rq);
    }
}
