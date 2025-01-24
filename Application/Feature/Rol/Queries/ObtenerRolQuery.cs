
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Rol;
using MediatR;

namespace Application.Feature.Rol.Queries
{
    public class ObtenerRolQuery : IRequest<ListResponse<RolResponse>>
    {
    }
}
