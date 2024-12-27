

using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Queries;
using MediatR;

namespace Application.Feature.User.Queries
{
    public class ObtenerUsuarioQuery:IRequest<ListResponse<Usuario>>
    {


    }
}
