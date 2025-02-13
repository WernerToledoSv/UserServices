using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Mision;
using MediatR;

namespace Application.Feature.Mision.Queries
{
    public class ListadoMisionQuery : IRequest<ListResponse<MisionResponse>>
    {
    }
}
