

using Application.Feature.Usuario.Commands;
using Application.Feature.Usuario.Queries;
using Application.Interfaces.Services;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;

namespace Application.UseCase
{
    public class UsuarioUseCase : IUsuarioUseCase
    {
        #region Atributos
        private readonly IUsuarioService _service;
        #endregion

        #region Constructor
        public UsuarioUseCase(IUsuarioService service)
        {
            _service = service;
        }
        #endregion

        #region Metodos
        public async Task<ObjectResponse<UsuarioResponse>> ActivarUsuario(ActivarUsuarioCommand rq)
        {
            var rs = new ObjectResponse<UsuarioResponse>();
            var response = await _service.ActivarUsuario(rq);
            if (response != null)
            {
                rs = new ObjectResponse<UsuarioResponse>
                {
                    Code = 1,
                    Message = "Exito al activar el usuario.",
                    Item = response
                };
            }
            else
            {
                rs = new ObjectResponse<UsuarioResponse>
                {
                    Code = 1,
                    Message = "Error al activar el usuario.",
                    Item = null
                };
            }
            return rs;
        }

        public async Task<ObjectResponse<UsuarioResponse>> ActualizarUsuario(ActualizarUsuarioCommand rq)
        {
            var rs = new ObjectResponse<UsuarioResponse>();

            var response = await _service.ActualizarUsuario(rq);
            if (response != null)
            {
                rs = new ObjectResponse<UsuarioResponse>
                {
                    Code = 1,
                    Message = "Exito al actualizar el usuario.",
                    Item = response
                };

            }
            else
            {
                rs = new ObjectResponse<UsuarioResponse>
                {
                    Code = 0,
                    Message = "Error al actualizar el usuario.",
                    Item = null
                };
            }
            return rs;
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
                    Item = usuarioIngresado
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

        public async Task<ObjectResponse<UsuarioResponse>> BuscarUsuarioById(BuscarUsuarioByIdQuery rq)
        {
            var rs = new ObjectResponse<UsuarioResponse>();

            var response = await _service.BuscarById(rq);
            if (response != null)
            {
                rs = new ObjectResponse<UsuarioResponse>
                {
                    Code = 1,
                    Message = "Exito al buscar el usuario por id.",
                    Item = response
                };

            }
            else
            {
                rs = new ObjectResponse<UsuarioResponse>
                {
                    Code = 0,
                    Message = "No se encontraron registros",
                    Item = null
                };
            }
            return rs;
        }

        public async Task<ListResponse<UsuarioResponse>> BuscarUsuarioByNombre(BuscarUsuarioByNombreQuery rq)
        {
            var rs = new ListResponse<UsuarioResponse>();

            var response = await _service.BuscarUsuarioByNombre(rq);
            if (response.Any())
            {
                rs = new ListResponse<UsuarioResponse>
                {
                    Code = 1,
                    Message = "Exito al buscar el usuario por id.",
                    Items = response
                };

            }
            else
            {
                rs = new ListResponse<UsuarioResponse>
                {
                    Code = 0,
                    Message = "No se encontraron registros",
                    Items = null
                };
            }
            return rs;
        }

        public async Task<ObjectResponse<UsuarioResponse>> EliminarUsuario(EliminarUsuarioCommand rq)
        {
            var rs = new ObjectResponse<UsuarioResponse>();

            var response = await _service.EliminarUsuario(rq);
            if (response != null)
            {
                rs = new ObjectResponse<UsuarioResponse>
                {
                    Code = 1,
                    Message = "Exito al eliminar el usuario.",
                    Item = response
                };

            }
            else
            {
                rs = new ObjectResponse<UsuarioResponse>
                {
                    Code = 0,
                    Message = "Error al eliminar el usuario.",
                    Item = null
                };
            }
            return rs;
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
        #endregion
    }
}
