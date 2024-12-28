

using Domain.Entities.BaseResponse;
using MediatR;

namespace Application.Feature.User.Queries
{
    using Domain.Entities.Services.Queries;
    public class ObtenerUsuarioQuery:IRequest<ListResponse<Usuario>>
    {


    }
}
