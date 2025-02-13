

using Application.Feature.Usuario.Commands;
using Application.Feature.Usuario.Queries;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;

namespace Application.UseCase.Interfaces
{
    public interface IUsuarioUseCase
    {
        #region Queries
        Task<ObjectResponse<UsuarioResponse>> BuscarUsuarioById(BuscarUsuarioByIdQuery rq);
        Task<ListResponse<UsuarioResponse>> BuscarUsuarioByNombre(BuscarUsuarioByNombreQuery rq);
        Task<ListResponse<UsuarioResponse>> ListadoUsuario();
        #endregion

        #region Commands
        Task<ObjectResponse<UsuarioResponse>> ActivarUsuario(ActivarUsuarioCommand rq);
        Task<ObjectResponse<UsuarioResponse>> AgregarUsuario(IngresarUsuarioCommand rq);
        Task<ObjectResponse<UsuarioResponse>> ActualizarUsuario(ActualizarUsuarioCommand rq);
        Task<ObjectResponse<UsuarioResponse>> EliminarUsuario(EliminarUsuarioCommand rq);
        #endregion
    }
}
