

using Application.Feature.User.Queries;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Queries;
using MediatR;

namespace Application.Handler.Queries
{
    public class ObtenerUsuarioQueryHandler : IRequestHandler<ObtenerUsuarioQuery, ListResponse<Usuario>>
    {
        private readonly IUsuarioUseCase usuarioUseCase;

        public ObtenerUsuarioQueryHandler(IUsuarioUseCase usuarioUseCase)
        {
            this.usuarioUseCase = usuarioUseCase;
        }

        public async Task<ListResponse<Usuario>> Handle(ObtenerUsuarioQuery request, CancellationToken cancellationToken)
        {
            var rs = await usuarioUseCase.ListadoUsuario();
            return rs;
        }
    }
}
