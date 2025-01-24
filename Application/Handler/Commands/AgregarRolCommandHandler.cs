
using Application.Feature.Rol.Commands;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Rol;
using MediatR;

namespace Application.Handler.Commands
{
    public class AgregarRolCommandHandler : IRequestHandler<AgregarRolCommand, ObjectResponse<RolResponse>>
    {
        private readonly IRolUseCase rolUseCase;

        public AgregarRolCommandHandler(IRolUseCase rolUseCase)
        {
            this.rolUseCase = rolUseCase;
        }

        public async Task<ObjectResponse<RolResponse>> Handle(AgregarRolCommand request, CancellationToken cancellationToken)
        {
            var rs = await rolUseCase.AgregarRol(request);
            return rs;
        }
    }
}
