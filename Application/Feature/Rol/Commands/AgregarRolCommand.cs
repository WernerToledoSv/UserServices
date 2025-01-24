
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Rol;
using MediatR;

namespace Application.Feature.Rol.Commands
{
    public class AgregarRolCommand : IRequest<ObjectResponse<RolResponse>>
    {
        public string pnombre { get; set; }
        public string pdescripcion { get; set; }
    }
}
