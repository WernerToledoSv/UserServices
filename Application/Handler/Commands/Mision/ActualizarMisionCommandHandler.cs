using Application.Feature.Mision.Commands;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Mision;
using MediatR;

namespace Application.Handler.Commands.Mision
{
    public class ActualizarMisionCommandHandler : IRequestHandler<ActualizarMisionCommand, ObjectResponse<MisionResponse>>
    {
        private readonly IMisionUseCase misionUseCase;

        public ActualizarMisionCommandHandler(IMisionUseCase misionUseCase)
        {
            this.misionUseCase = misionUseCase;
        }

        public Task<ObjectResponse<MisionResponse>> Handle(ActualizarMisionCommand request, CancellationToken cancellationToken)
        {
            var rs = misionUseCase.ActualizarMision(request);
            return rs;
        }
    }
}
