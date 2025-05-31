using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Feature.Usuario.Queries
{
    public class LoginUsuarioQuery : IRequest<ObjectResponse<LoginResponse>>
    {
        [Required(ErrorMessage = "EL campo pUserName es obligatorio")]
        public string pUserName { get; set; }
        [Required(ErrorMessage = "EL campo pPassword es obligatorio")]
        public string pPassword { get; set; }   
    }
}
