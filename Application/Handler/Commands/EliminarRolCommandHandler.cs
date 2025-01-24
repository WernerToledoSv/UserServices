
using Application.Feature.Rol.Commands;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Rol;
using MediatR;

namespace Application.Handler.Commands
{
    public class EliminarRolCommandHandler : IRequestHandler<EliminarRolCommand, ObjectResponse<RolResponse>>
    {
        private readonly IRolUseCase rolUseCase;

        public EliminarRolCommandHandler(IRolUseCase rolUseCase)
        {
            this.rolUseCase = rolUseCase;
        }

        public async Task<ObjectResponse<RolResponse>> Handle(EliminarRolCommand request, CancellationToken cancellationToken)
        {
            var rs = await rolUseCase.EliminarRol(request);
            return rs;
        }
    }
}
