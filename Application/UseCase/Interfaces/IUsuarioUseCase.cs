

using Application.Feature.Usuario.Commands;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Queries;
using Domain.Entities.Services.Queries.UserEntities;

namespace Application.UseCase.Interfaces
{
    public interface IUsuarioUseCase
    {
        Task<ListResponse<UsuarioEntity>> ListadoUsuario();
        Task<ObjectResponse<UsuarioEntity>> AgregarUsuario(IngresarUsuarioCommand rq);
        Task<ObjectResponse<UsuarioEntity>> ActualizarUsuario();
        Task<ObjectResponse<UsuarioEntity>> EliminarUsuario();


    }
}
