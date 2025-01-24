
using Application.Feature.Rol.Queries;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Rol;
using MediatR;

namespace Application.Handler.Queries
{
    public class BuscarByIdQueryHandler : IRequestHandler<BuscarRolByIdQuery, ObjectResponse<RolResponse>>
    {
        private readonly IRolUseCase rolUseCase;

        public BuscarByIdQueryHandler(IRolUseCase rolUseCase)
        {
            this.rolUseCase = rolUseCase;
        }

        public async Task<ObjectResponse<RolResponse>> Handle(BuscarRolByIdQuery request, CancellationToken cancellationToken)
        {
            var rs = await rolUseCase.BuscarRolById(request);
            return rs;
        }
    }
}
