
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Feature.Usuario.Queries
{
    public class BuscarUsuarioByIdQuery : IRequest<ObjectResponse<UsuarioResponse>>
    {
        [Required(ErrorMessage = "EL campo pId es obligatorio")]
        public long pId { get; set; }
    }
}
