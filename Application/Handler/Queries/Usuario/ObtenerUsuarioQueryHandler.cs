using Application.Feature.User.Queries;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;
using MediatR;

namespace Application.Handler.Queries.Usuario
{
    public class ObtenerUsuarioQueryHandler : IRequestHandler<ObtenerUsuarioQuery, ListResponse<UsuarioResponse>>
    {
        private readonly IUsuarioUseCase usuarioUseCase;

        public ObtenerUsuarioQueryHandler(IUsuarioUseCase usuarioUseCase)
        {
            this.usuarioUseCase = usuarioUseCase;
        }

        public async Task<ListResponse<UsuarioResponse>> Handle(ObtenerUsuarioQuery request, CancellationToken cancellationToken)
        {
            var rs = await usuarioUseCase.ListadoUsuario();
            return rs;
        }
    }
}
