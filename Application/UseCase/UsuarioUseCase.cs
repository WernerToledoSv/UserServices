

using Application.Interfaces.Services;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Queries;

namespace Application.UseCase
{
    public class UsuarioUseCase : IUsuarioUseCase
    {
        private readonly IUsuarioService _service;

        public UsuarioUseCase(IUsuarioService service)
        {
            _service = service;
        }

        public Task<ObjectResponse<Usuario>> ActualizarUsuario()
        {
            throw new NotImplementedException();
        }

        public Task<ObjectResponse<Usuario>> AgregarUsuario()
        {
            throw new NotImplementedException();
        }

        public Task<ObjectResponse<Usuario>> EliminarUsuario()
        {
            throw new NotImplementedException();
        }

        public async Task<ListResponse<Usuario>> ListadoUsuario()
        {
            var rs = new ListResponse<Usuario>();
            try
            {
                var lusuario = await _service.ListadoUsuario();    
                if (lusuario.Count != 0 && lusuario != null)
                {
                    rs = new ListResponse<Usuario>
                    {
                        Code = 1,
                        Message = "Obtencion del listado de usuario exitosa.",
                        Items = lusuario
                    };
                }
                else
                {
                    rs = new ListResponse<Usuario>
                    {
                        Code = 1,
                        Message = "No existen datos.",
                        Items = null
                    };
                }
            }
            catch (Exception ex)
            {
                rs = new ListResponse<Usuario>
                {
                    Code = 1,
                    Message = "Error fatal en obtencion del listado de usuario.",
                    Items = null
                };
            }
            return rs;
        }
    }
}
