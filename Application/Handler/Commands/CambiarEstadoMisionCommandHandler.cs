
using Application.Feature.Mision.Commands;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Mision;
using MediatR;

namespace Application.Handler.Commands
{
    public class CambiarEstadoMisionCommandHandler : IRequestHandler<CambiarEstadoMisionCommand, ObjectResponse<MisionResponse>>
    {
        private readonly IMisionUseCase misionUseCase;

        public CambiarEstadoMisionCommandHandler(IMisionUseCase misionUseCase)
        {
            this.misionUseCase = misionUseCase;
        }

        public Task<ObjectResponse<MisionResponse>> Handle(CambiarEstadoMisionCommand request, CancellationToken cancellationToken)
        {
            var rs = misionUseCase.CambiarEstadoMision(request);
            return rs;
        }
    }
}
