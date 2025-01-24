using Application.Feature.Rol.Commands;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Rol;
using MediatR;

namespace Application.Handler.Commands
{
    public class ActualizarRolCommandHandler : IRequestHandler<ActualizarRolCommand, ObjectResponse<RolResponse>>
    {
        private readonly IRolUseCase rolUseCase;

        public ActualizarRolCommandHandler(IRolUseCase rolUseCase)
        {
            this.rolUseCase = rolUseCase;
        }

        public async Task<ObjectResponse<RolResponse>> Handle(ActualizarRolCommand request, CancellationToken cancellationToken)
        {
            var rs = await rolUseCase.ActualizarRol(request);
            return rs;
        }
    }
}
