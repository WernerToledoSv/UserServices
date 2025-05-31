
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.UnionMisionLugar;
using MediatR;

namespace Application.Feature.UnionMisionLugar.Queries
{
    public class ListadoUnionQuery : IRequest<ListResponse<ListadoUnionResponse>>
    {
    }
}
