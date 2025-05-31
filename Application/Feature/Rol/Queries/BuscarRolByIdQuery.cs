
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Rol;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Feature.Rol.Queries
{
    public class BuscarRolByIdQuery : IRequest<ObjectResponse<RolResponse>>
    {
        [Required(ErrorMessage = "EL campo pId es obligatorio")]
        public long pId { get; set; }
    }
}
