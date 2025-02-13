
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Rol;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Feature.Rol.Queries
{
    public class BuscarRolByNombreQuery : IRequest<ListResponse<RolResponse>>
    {
        [Required(ErrorMessage = "EL campo pNombre es obligatorio")]
        public string pNombre { get; set; }
    }
}
