

using Application.Feature.Usuario.Commands;
using Application.Interfaces.Services;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;

namespace Application.UseCase
{
    public class UsuarioUseCase : IUsuarioUseCase
    {
        private readonly IUsuarioService _service;

        public UsuarioUseCase(IUsuarioService service)
        {
            _service = service;
        }

        public Task<ObjectResponse<UsuarioResponse>> ActualizarUsuario()
        {
            throw new NotImplementedException();
        }

        public async Task<ObjectResponse<UsuarioResponse>> AgregarUsuario(IngresarUsuarioCommand rq)
        {
            var rs = new ObjectResponse<UsuarioResponse>();
           
            var usuarioIngresado = await _service.AgregarUsuario(rq);
            if (usuarioIngresado != null)
            {
                rs = new ObjectResponse<UsuarioResponse>
                {
                    Code = 1,
                    Message = "Exito al ingresar el usuario.",
                    Item = (UsuarioResponse)usuarioIngresado
                };

            }
            else 
            {
                rs = new ObjectResponse<UsuarioResponse>
                {
                    Code = 0,
                    Message = "Error al ingresar el usuario.",
                    Item = null
                };
            }
            return rs;
        }

        public Task<ObjectResponse<UsuarioResponse>> EliminarUsuario()
        {
            throw new NotImplementedException();
        }

        public async Task<ListResponse<UsuarioResponse>> ListadoUsuario()
        {
            var rs = new ListResponse<UsuarioResponse>();
          
            var lusuario = await _service.ListadoUsuario();    
            if (lusuario.Count != 0 && lusuario != null)
            {
                rs = new ListResponse<UsuarioResponse>
                {
                    Code = 0,
                    Message = "Obtencion del listado de usuario exitosa.",
                    Items = lusuario
                };
            }
            else
            {
                rs = new ListResponse<UsuarioResponse>
                {
                    Code = 1,
                    Message = "No existen datos.",
                    Items = null
                };
            }
            return rs;
        }
    }
}
