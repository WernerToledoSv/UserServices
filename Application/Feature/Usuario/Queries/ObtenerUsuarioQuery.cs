using Domain.Entities.BaseResponse;
using MediatR;
using Domain.Entities.Services.Usuario;

namespace Application.Feature.User.Queries
{
    
    public class ObtenerUsuarioQuery:IRequest<ListResponse<UsuarioResponse>>
    {


    }
}
