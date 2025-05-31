using Application.Feature.Usuario.Queries;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;
using MediatR;

namespace Application.Handler.Queries.Usuario
{
    public class BuscarUsuarioByIdQueryHandler : IRequestHandler<BuscarUsuarioByIdQuery, ObjectResponse<UsuarioResponse>>
    {
        private readonly IUsuarioUseCase usuarioUseCase;

        public BuscarUsuarioByIdQueryHandler(IUsuarioUseCase usuarioUseCase)
        {
            this.usuarioUseCase = usuarioUseCase;
        }

        public Task<ObjectResponse<UsuarioResponse>> Handle(BuscarUsuarioByIdQuery request, CancellationToken cancellationToken)
        {
            var rs = usuarioUseCase.BuscarUsuarioById(request);
            return rs;
        }
    }
}
