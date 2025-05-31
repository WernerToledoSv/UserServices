using Application.Feature.Usuario.Queries;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;
using MediatR;

namespace Application.Handler.Queries.Usuario
{
    public class LoginUsuarioQueryHanldler : IRequestHandler<LoginUsuarioQuery, ObjectResponse<LoginResponse>>
    {
        private readonly IUsuarioUseCase _usuarioUseCase;

        public LoginUsuarioQueryHanldler(IUsuarioUseCase usuarioUseCase)
        {
            _usuarioUseCase = usuarioUseCase;
        }

        public async Task<ObjectResponse<LoginResponse>> Handle(LoginUsuarioQuery request, CancellationToken cancellationToken)
        {
            var rs = await _usuarioUseCase.LoginUsuario(request);
            return rs;
        }
    }
}
