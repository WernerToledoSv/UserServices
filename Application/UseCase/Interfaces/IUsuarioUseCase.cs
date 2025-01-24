

using Application.Feature.Usuario.Commands;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;

namespace Application.UseCase.Interfaces
{
    public interface IUsuarioUseCase
    {
        Task<ListResponse<UsuarioResponse>> ListadoUsuario();
        Task<ObjectResponse<UsuarioResponse>> AgregarUsuario(IngresarUsuarioCommand rq);
        Task<ObjectResponse<UsuarioResponse>> ActualizarUsuario();
        Task<ObjectResponse<UsuarioResponse>> EliminarUsuario();


    }
}
