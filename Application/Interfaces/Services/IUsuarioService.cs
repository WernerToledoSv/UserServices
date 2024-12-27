

using Domain.Entities.Services.Queries;

namespace Application.Interfaces.Services
{
    public interface IUsuarioService
    {

       IList<Usuario>  ListadoUsuario();

        Usuario AgregarUsuario();
        Usuario ActualizarUsuario();
        Usuario EliminarUsuario();

    }
}
