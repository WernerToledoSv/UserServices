
using Application.Feature.UnionMisionLugar.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Application.Interfaces.Services
{
    public interface IUnionMisionLugarService
    {
        Task<bool> AgregarUnion(AgregarUnionCommand rq);
        Task<bool> EliminarUnion(EliminarUnionCommand rq);
        Task<bool> ActualizarUnion(ActualizarUnionCommand rq);
    }
}
