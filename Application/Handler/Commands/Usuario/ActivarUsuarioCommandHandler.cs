using Application.Feature.Usuario.Commands;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;
using MediatR;

namespace Application.Handler.Commands.Usuario
{
    public class ActivarUsuarioCommandHandler : IRequestHandler<ActivarUsuarioCommand, ObjectResponse<UsuarioResponse>>
    {
        private readonly IUsuarioUseCase usuarioUseCase;

        public ActivarUsuarioCommandHandler(IUsuarioUseCase usuarioUseCase)
        {
            this.usuarioUseCase = usuarioUseCase;
        }

        public Task<ObjectResponse<UsuarioResponse>> Handle(ActivarUsuarioCommand request, CancellationToken cancellationToken)
        {
            var rs = usuarioUseCase.ActivarUsuario(request);

            return rs;
        }
    }
}
