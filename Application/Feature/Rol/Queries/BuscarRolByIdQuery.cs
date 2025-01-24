
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Rol;
using MediatR;

namespace Application.Feature.Rol.Queries
{
    public class BuscarRolByIdQuery : IRequest<ObjectResponse<RolResponse>>
    {
        public int pId { get; set; }
    }
}
