

using Application.Feature.Usuario.Commands;
using Domain.Entities.Services.Queries;
using Domain.Entities.Services.Queries.UserEntities;

namespace Application.Interfaces.Services
{
    public interface IUsuarioService
    {
        Task<IList<UsuarioEntity>>  ListadoUsuario();
        Task<IEnumerable<UsuarioEntity>> AgregarUsuario(IngresarUsuarioCommand rq);
        Task<UsuarioEntity> ActualizarUsuario();
        Task<UsuarioEntity> EliminarUsuario();

    }
}
