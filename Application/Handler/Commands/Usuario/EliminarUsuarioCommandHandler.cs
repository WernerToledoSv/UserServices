using Application.Feature.Usuario.Commands;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;
using MediatR;

namespace Application.Handler.Commands.Usuario
{
    public class EliminarUsuarioCommandHandler : IRequestHandler<EliminarUsuarioCommand, ObjectResponse<UsuarioResponse>>
    {
        private readonly IUsuarioUseCase usuarioUseCase;

        public EliminarUsuarioCommandHandler(IUsuarioUseCase usuarioUseCase)
        {
            this.usuarioUseCase = usuarioUseCase;
        }

        public Task<ObjectResponse<UsuarioResponse>> Handle(EliminarUsuarioCommand request, CancellationToken cancellationToken)
        {
            var rs = usuarioUseCase.EliminarUsuario(request);
            return rs;
        }
    }
}
