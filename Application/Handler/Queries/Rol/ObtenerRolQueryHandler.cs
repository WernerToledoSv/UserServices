using Application.Feature.Rol.Queries;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Rol;
using MediatR;

namespace Application.Handler.Queries.Rol
{
    public class ObtenerRolQueryHandler : IRequestHandler<ObtenerRolQuery, ListResponse<RolResponse>>

    {
        private readonly IRolUseCase rolUseCase;

        public ObtenerRolQueryHandler(IRolUseCase rolUseCase)
        {
            this.rolUseCase = rolUseCase;
        }

        public async Task<ListResponse<RolResponse>> Handle(ObtenerRolQuery request, CancellationToken cancellationToken)
        {
            var rs = await rolUseCase.ObtenerRoles();
            return rs;
        }
    }
}
