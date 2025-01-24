

using Application.Feature.Rol.Commands;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Rol;
using MediatR;

namespace Application.Handler.Commands
{
    public class ActivarRolCommandHandler : IRequestHandler<ActivarRolCommand, ObjectResponse<RolResponse>>
    {
        private readonly IRolUseCase rolUseCase;

        public ActivarRolCommandHandler(IRolUseCase rolUseCase)
        {
            this.rolUseCase = rolUseCase;
        }

        public async Task<ObjectResponse<RolResponse>> Handle(ActivarRolCommand request, CancellationToken cancellationToken)
        {
            var rs = await rolUseCase.ActivarRol(request);
            return rs;
        }
    }
}

