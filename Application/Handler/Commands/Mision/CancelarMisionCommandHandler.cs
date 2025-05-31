using Application.Feature.Mision.Commands;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Mision;
using MediatR;

namespace Application.Handler.Commands.Mision
{
    public class CancelarMisionCommandHandler : IRequestHandler<CancelarMisionCommand, ObjectResponse<MisionResponse>>
    {
        private readonly IMisionUseCase misionUseCase;

        public CancelarMisionCommandHandler(IMisionUseCase misionUseCase)
        {
            this.misionUseCase = misionUseCase;
        }

        public Task<ObjectResponse<MisionResponse>> Handle(CancelarMisionCommand request, CancellationToken cancellationToken)
        {
            var rs = misionUseCase.CancelarMision(request);
            return rs;
        }
    }
}
