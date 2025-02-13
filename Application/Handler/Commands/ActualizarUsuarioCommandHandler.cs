using Application.Feature.Usuario.Commands;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;
using MediatR;

namespace Application.Handler.Commands
{
    public class ActualizarUsuarioCommandHandler : IRequestHandler<ActualizarUsuarioCommand, ObjectResponse<UsuarioResponse>>
    {
        private readonly IUsuarioUseCase usuarioUseCase;

        public ActualizarUsuarioCommandHandler(IUsuarioUseCase usuarioUseCase)
        {
            this.usuarioUseCase = usuarioUseCase;
        }

        public Task<ObjectResponse<UsuarioResponse>> Handle(ActualizarUsuarioCommand request, CancellationToken cancellationToken)
        {
            var rs = usuarioUseCase.ActualizarUsuario(request);
            return rs;
        }
    }
}
