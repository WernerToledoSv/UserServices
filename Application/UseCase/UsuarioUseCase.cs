

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

        public Task<ListResponse<Usuario>> ListadoUsuario()
        {
            IList<Usuario> lusuario = await _service.ListadoUsuario();
            if (lusuario.Count != 0 && lusuario != null)
            {
                var rs = new ListResponse<Usuario>
                {
                    Code = 1,
                    Message = "Obtencion del listado de usuario exitosa.",
                    Items = lusuario
                };
                //return rs;

            }
            else
            {
                var rs = new ListResponse<Usuario>
                {
                    Code = 0,
                    Message = "Error en obtencion del listado de usuario.",
                    Items = null
                };
                //return rs;
            }
            throw new NotImplementedException();
        }
    }
}
