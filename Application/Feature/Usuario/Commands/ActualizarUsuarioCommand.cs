
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;
using MediatR;

namespace Application.Feature.Usuario.Commands
{
    public class ActualizarUsuarioCommand : IRequest<ObjectResponse<UsuarioResponse>>
    {
        public int pIUsuario { get; set; }
        public int pIdRol { get; set; }
        public int pIdLugar { get; set; }
        public string pUsername { get; set; }
        public string pPassword { get; set; }
        public string pNombres { get; set; }
        public string pApellidos { get; set; }
        public string pSexo { get; set; }
        public string pCel { get; set; }
        public string pEmail { get; set; }
    }
}
