
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Rol;
using MediatR;

namespace Application.Feature.Rol.Commands
{
    public class ActualizarRolCommand : IRequest<ObjectResponse<RolResponse>>
    {
        public int pId { get; set; }
        public string pNombre { get; set; }
        public string pDescripcion { get; set; }
    }
}
