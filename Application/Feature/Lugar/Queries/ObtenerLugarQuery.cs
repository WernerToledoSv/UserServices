
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Lugar;
using MediatR;

namespace Application.Feature.Lugar.Queries
{
    public class ObtenerLugarQuery : IRequest<ListResponse<LugarResponse>>
    {
    }
}
