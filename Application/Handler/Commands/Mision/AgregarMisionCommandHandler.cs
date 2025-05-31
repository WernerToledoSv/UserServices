using Application.Feature.Mision.Commands;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Mision;
using MediatR;

namespace Application.Handler.Commands.Mision
{
    public class AgregarMisionCommandHandler : IRequestHandler<AgregarMisionCommand, ObjectResponse<MisionResponse>>
    {
        private readonly IMisionUseCase misionUseCase;

        public AgregarMisionCommandHandler(IMisionUseCase misionUseCase)
        {
            this.misionUseCase = misionUseCase;
        }

        public Task<ObjectResponse<MisionResponse>> Handle(AgregarMisionCommand request, CancellationToken cancellationToken)
        {
            var rs = misionUseCase.AgregarMision(request);
            return rs;
        }
    }
}
