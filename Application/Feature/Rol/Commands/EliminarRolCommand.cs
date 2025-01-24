
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Rol;
using MediatR;

namespace Application.Feature.Rol.Commands
{
    public class EliminarRolCommand : IRequest<ObjectResponse<RolResponse>>
    {
        public int pId { get; set; }
    }
}
