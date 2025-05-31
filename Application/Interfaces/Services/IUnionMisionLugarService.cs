
using Application.Feature.UnionMisionLugar.Commands;
using Domain.Entities.Services.UnionMisionLugar;
using Microsoft.AspNetCore.Mvc;

namespace Application.Interfaces.Services
{
    public interface IUnionMisionLugarService
    {
        Task<bool> AgregarUnion(AgregarUnionCommand rq);
        Task<bool> EliminarUnion(EliminarUnionCommand rq);
        Task<bool> ActualizarUnion(ActualizarUnionCommand rq);
        Task<IList<ListadoUnionResponse>> ListadoUnion();
    }
}
