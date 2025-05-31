using Application.Feature.Usuario.Commands;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;
using MediatR;

namespace Application.Handler.Commands.Usuario
{
    public class IngresarUsuarioCommandHandler : IRequestHandler<IngresarUsuarioCommand, ObjectResponse<UsuarioResponse>>
    {
        private readonly IUsuarioUseCase usuarioUseCase;

        public IngresarUsuarioCommandHandler(IUsuarioUseCase usuarioUseCase)
        {
            this.usuarioUseCase = usuarioUseCase;
        }

        public async Task<ObjectResponse<UsuarioResponse>> Handle(IngresarUsuarioCommand request, CancellationToken cancellationToken)
        {
            var rs = await usuarioUseCase.AgregarUsuario(request);
            return rs;
        }
    }
}