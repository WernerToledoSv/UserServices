

using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Queries;

namespace Application.UseCase.Interfaces
{
    public interface IUsuarioUseCase
    {

        Task< ListResponse<Usuario>> ListadoUsuario();
        

        Task<ObjectResponse<Usuario>> AgregarUsuario();
        Task<ObjectResponse<Usuario>> ActualizarUsuario();
        Task<ObjectResponse<Usuario>> EliminarUsuario();


    }
}
