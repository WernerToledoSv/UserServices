
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Feature.Usuario.Commands
{
    public class ActualizarUsuarioCommand : IRequest<ObjectResponse<UsuarioResponse>>
    {
        public long pId { get; set; }
        public long pIdRol { get; set; }
        public long pIdLugar { get; set; }
        public string pUsername { get; set; }
        public string pPassword { get; set; }
        public string pNombres { get; set; }
        public string pApellidos { get; set; }
        public string pSexo { get; set; }
        public string pCel { get; set; }
        
        [EmailAddress]
        public string pEmail { get; set; }
    }
}
