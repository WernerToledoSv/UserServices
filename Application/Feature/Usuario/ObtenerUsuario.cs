using Domain.Entities.UserEntities;
using MediatR;

namespace Application.Feature.Usuario;

public class ObtenerUsuario : IRequest<UsuarioEntity>
{
}
