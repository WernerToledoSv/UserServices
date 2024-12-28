

using Domain.Entities.Services.Queries;

namespace Application.Interfaces.Services
{
    public interface IUsuarioService
    {
        Task<IList<Usuario>>  ListadoUsuario();
        Task<Usuario> AgregarUsuario();
        Task<Usuario> ActualizarUsuario();
        Task<Usuario> EliminarUsuario();

    }
}
