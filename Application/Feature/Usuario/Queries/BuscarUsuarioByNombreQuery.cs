
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Feature.Usuario.Queries
{
    public class BuscarUsuarioByNombreQuery : IRequest<ListResponse<UsuarioResponse>>
    {
        [Required(ErrorMessage = "EL campo pNombre es obligatorio")]
        public string pNombres { get; set; }
    }
}
