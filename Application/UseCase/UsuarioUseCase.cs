

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
        private readonly IEncriptacionService _encriptacionService;

        #endregion

        #region Constructor
        public UsuarioUseCase(IUsuarioService service, IEncriptacionService encriptacionService)
        {
            _service = service;
            _encriptacionService = encriptacionService;
        }
        #endregion

        #region Metodos
        public async Task<ObjectResponse<UsuarioResponse>> ActivarUsuario(ActivarUsuarioCommand rq)
        {
            var rs = new ObjectResponse<UsuarioResponse>();

            var bandExiste = await _service.BuscarById(rq.pId);
            if (bandExiste ==  null)
            {
                rs = new ObjectResponse<UsuarioResponse>
                {
                    Code = 0,
                    Message = "Error no existe el usuario",
                    Item = null
                };
                return rs;
            }

            var response = await _service.ActivarUsuario(rq);
            if (response != null)
            {
                response.Password = _encriptacionService.Desencriptar(response.Password);
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
                    Message = "Error, no se encontró registro",
                    Item = null
                };
            }
            return rs;
        }

        public async Task<ObjectResponse<UsuarioResponse>> ActualizarUsuario(ActualizarUsuarioCommand rq)
        {
            var rs = new ObjectResponse<UsuarioResponse>();
            rq.pPassword = _encriptacionService.Encriptar(rq.pPassword);

            var response = await _service.ActualizarUsuario(rq);
            if (response != null)
            {
                response.Password = _encriptacionService.Desencriptar(response.Password);
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
                    Message = "Error, no se encontró registro",
                    Item = null
                };
            }
            return rs;
        }

        public async Task<ObjectResponse<UsuarioResponse>> AgregarUsuario(IngresarUsuarioCommand rq)
        {
            var rs = new ObjectResponse<UsuarioResponse>();

            rq.pPassword = _encriptacionService.Encriptar(rq.pPassword);

            var usuarioIngresado = await _service.AgregarUsuario(rq);
            if (usuarioIngresado != null)
            {
                usuarioIngresado.Password = _encriptacionService.Desencriptar(usuarioIngresado.Password);
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

            var response = await _service.BuscarById(rq.pId);
            if (response != null)
            {
                response.Password = _encriptacionService.Desencriptar(response.Password); 
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
                    Message = "Error, no se encontró registro",
                    Item = null
                };
            }
            return rs;
        }

        public async Task<ListResponse<UsuarioResponse>> BuscarUsuarioByNombre(BuscarUsuarioByNombreQuery rq)
        {
            var rs = new ListResponse<UsuarioResponse>();

            var response = await _service.BuscarUsuarioByNombre(rq.pNombres);
            if (response.Any())
            {
                ((List<UsuarioResponse>)response).ForEach(usuario => usuario.Password = _encriptacionService.Desencriptar(usuario.Password));
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
                    Message = "Error, no se encontraron registros",
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
                response.Password = _encriptacionService.Desencriptar(response.Password);
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
                    Message = "Error, no se encontró registro",
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
                ((List<UsuarioResponse>)lusuario).ForEach(usuario => usuario.Password = _encriptacionService.Desencriptar(usuario.Password));
                rs = new ListResponse<UsuarioResponse>
                {
                    Code = 1,
                    Message = "Obtencion del listado de usuario exitosa.",
                    Items = lusuario
                };
            }
            else
            {
                rs = new ListResponse<UsuarioResponse>
                {
                    Code = 1,
                    Message = "Error, no se encontraron registros",
                    Items = null
                };
            }
            return rs;
        }

        public async Task<ObjectResponse<LoginResponse>> LoginUsuario(LoginUsuarioQuery rq)
        {
            var rs = new ObjectResponse<LoginResponse>();
            rq.pPassword = _encriptacionService.Encriptar(rq.pPassword);

            var login = await _service.LoginUsuario(rq);
            if (login!=null && login.IdRol > 0) 
            {
                rs = new ObjectResponse<LoginResponse>
                {
                    Code = 1,
                    Message = "Login exitoso.",
                    Item = login
                };
            }
            else 
            {
                rs = new ObjectResponse<LoginResponse>
                {
                    Code = 0,
                    Message = "Credenciales incorrectas",
                    Item = null
                };
            }
            return rs;
        }

        #endregion
    }
}
