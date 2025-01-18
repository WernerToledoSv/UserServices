

using Application.Feature.Usuario.Commands;
using Application.Interfaces.Services;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Queries.UserEntities;

namespace Application.UseCase
{
    public class UsuarioUseCase : IUsuarioUseCase
    {
        private readonly IUsuarioService _service;

        public UsuarioUseCase(IUsuarioService service)
        {
            _service = service;
        }

        public Task<ObjectResponse<UsuarioEntity>> ActualizarUsuario()
        {
            throw new NotImplementedException();
        }

        public async Task<ObjectResponse<UsuarioEntity>> AgregarUsuario(IngresarUsuarioCommand rq)
        {
            var rs = new ObjectResponse<UsuarioEntity>();
           
            var usuarioIngresado = await _service.AgregarUsuario(rq);
            if (usuarioIngresado != null)
            {
                rs = new ObjectResponse<UsuarioEntity>
                {
                    Code = 1,
                    Message = "Exito al ingresar el usuario.",
                    Item = (UsuarioEntity)usuarioIngresado
                };

            }
            else 
            {
                rs = new ObjectResponse<UsuarioEntity>
                {
                    Code = 0,
                    Message = "Error al ingresar el usuario.",
                    Item = null
                };
            }
            return rs;
        }

        public Task<ObjectResponse<UsuarioEntity>> EliminarUsuario()
        {
            throw new NotImplementedException();
        }

        public async Task<ListResponse<UsuarioEntity>> ListadoUsuario()
        {
            var rs = new ListResponse<UsuarioEntity>();
          
            var lusuario = await _service.ListadoUsuario();    
            if (lusuario.Count != 0 && lusuario != null)
            {
                rs = new ListResponse<UsuarioEntity>
                {
                    Code = 0,
                    Message = "Obtencion del listado de usuario exitosa.",
                    Items = lusuario
                };
            }
            else
            {
                rs = new ListResponse<UsuarioEntity>
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
