

using Domain.Entities.BaseResponse;
using MediatR;

namespace Application.Feature.User.Queries
{
    using Domain.Entities.Services.Queries;
    using Domain.Entities.Services.Queries.UserEntities;

    public class ObtenerUsuarioQuery:IRequest<ListResponse<UsuarioEntity>>
    {


    }
}
