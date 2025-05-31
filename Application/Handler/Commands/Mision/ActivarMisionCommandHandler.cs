using Application.Feature.Mision.Commands;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Mision;
using MediatR;

namespace Application.Handler.Commands.Mision
{
    public class ActivarMisionCommandHandler : IRequestHandler<ActivarMisionCommand, ObjectResponse<MisionResponse>>
    {
        private readonly IMisionUseCase _misionUseCase;

        public ActivarMisionCommandHandler(IMisionUseCase misionUseCase)
        {
            _misionUseCase = misionUseCase;
        }

        public async Task<ObjectResponse<MisionResponse>> Handle(ActivarMisionCommand request, CancellationToken cancellationToken)
        {
            var rs = await _misionUseCase.ActivarMision(request);
            return rs;
        }
    }
}
