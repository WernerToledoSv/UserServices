

using Application.Feature.Usuario.Commands;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Queries.UserEntities;

namespace Application.Interfaces.Services
{
    public interface IUsuarioService
    {
        Task<IList<UsuarioEntity>>  ListadoUsuario();
        Task<UsuarioEntity> AgregarUsuario(IngresarUsuarioCommand rq);
        Task<UsuarioEntity> ActualizarUsuario();
        Task<UsuarioEntity> EliminarUsuario();

    }
}
