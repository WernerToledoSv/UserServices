
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Rol;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Feature.Rol.Commands
{
    public class AgregarRolCommand : IRequest<ObjectResponse<RolResponse>>
    {
        [Required(ErrorMessage = "El campo pNombre es obligatorio")]
        public string pNombre { get; set; }
        [Required(ErrorMessage = "El campo pDescripcion es obligatorio")]
        public string pDescripcion { get; set; }
    }
}
