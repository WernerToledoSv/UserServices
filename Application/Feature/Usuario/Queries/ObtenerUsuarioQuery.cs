using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;
using MediatR;

namespace Application.Feature.User.Queries
{

    public class ObtenerUsuarioQuery : IRequest<ListResponse<UsuarioResponse>>
    {


    }
}
