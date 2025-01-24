

using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Rol;
using MediatR;

namespace Application.Feature.Rol.Commands
{
    public class ActivarRolCommand : IRequest<ObjectResponse<RolResponse>>
    {
        public int pId { get; set; }
    }
}
