

using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Rol;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Feature.Rol.Commands
{
    public class ActivarRolCommand : IRequest<ObjectResponse<RolResponse>>
    {
        [Required(ErrorMessage = "El campo pId es obligatorio")]
        public long pId { get; set; }
    }
}
