

using Application.Feature.Usuario.Commands;
using Application.Feature.Usuario.Queries;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;

namespace Application.Interfaces.Services
{
    public interface IUsuarioService
    {
        #region Queries
        Task<IList<UsuarioResponse>> ListadoUsuario();
        Task<UsuarioResponse> BuscarById(long rq);
        Task<UsuarioResponse> ActivarUsuario(ActivarUsuarioCommand rq);
        Task<IList<UsuarioResponse>> BuscarUsuarioByNombre(string rq);
        Task<LoginResponse> LoginUsuario(LoginUsuarioQuery rq);
        #endregion

        #region Commands
        Task<UsuarioResponse> AgregarUsuario(IngresarUsuarioCommand rq);
        Task<UsuarioResponse> ActualizarUsuario(ActualizarUsuarioCommand rq);
        Task<UsuarioResponse> EliminarUsuario(EliminarUsuarioCommand rq);
        #endregion
    }

}
