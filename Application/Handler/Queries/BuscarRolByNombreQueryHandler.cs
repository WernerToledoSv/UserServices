
using Application.Feature.Rol.Queries;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Rol;
using MediatR;

namespace Application.Handler.Queries
{
    public class BuscarRolByNombreQueryHandler : IRequestHandler<BuscarRolByNombreQuery, ListResponse<RolResponse>>
    {
        private readonly IRolUseCase rolUseCase;

        public BuscarRolByNombreQueryHandler(IRolUseCase rolUseCase)
        {
            this.rolUseCase = rolUseCase;
        }

        public async Task<ListResponse<RolResponse>> Handle(BuscarRolByNombreQuery request, CancellationToken cancellationToken)
        {
            var rs = await rolUseCase.BuscarRolByNombre(request);
            return rs;
        }
    }
}
