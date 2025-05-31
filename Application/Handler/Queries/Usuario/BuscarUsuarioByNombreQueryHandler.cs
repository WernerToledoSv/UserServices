using Application.Feature.Usuario.Queries;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;
using MediatR;

namespace Application.Handler.Queries.Usuario
{
    public class BuscarUsuarioByNombreQueryHandler : IRequestHandler<BuscarUsuarioByNombreQuery, ListResponse<UsuarioResponse>>
    {
        private readonly IUsuarioUseCase usuarioUseCase;

        public BuscarUsuarioByNombreQueryHandler(IUsuarioUseCase usuarioUseCase)
        {
            this.usuarioUseCase = usuarioUseCase;
        }

        public Task<ListResponse<UsuarioResponse>> Handle(BuscarUsuarioByNombreQuery request, CancellationToken cancellationToken)
        {
            var rs = usuarioUseCase.BuscarUsuarioByNombre(request);
            return rs;

        }
    }
}
