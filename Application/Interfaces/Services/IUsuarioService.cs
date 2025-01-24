

using Application.Feature.Usuario.Commands;
using Domain.Entities.Services.Usuario;

namespace Application.Interfaces.Services
{
    public interface IUsuarioService
    {
        Task<IList<UsuarioResponse>>  ListadoUsuario();
        Task<UsuarioResponse> AgregarUsuario(IngresarUsuarioCommand rq);
        Task<UsuarioResponse> ActualizarUsuario();
        Task<UsuarioResponse> EliminarUsuario();

    }
}
