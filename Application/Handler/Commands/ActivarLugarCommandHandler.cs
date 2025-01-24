
using Application.Feature.Lugar.Commands;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Lugar;
using MediatR;

namespace Application.Handler.Commands
{
    public class ActivarLugarCommandHandler : IRequestHandler<ActivarLugarCommand, ObjectResponse<LugarResponse>>
    {
        private readonly ILugarUseCase lugarUseCase;

        public ActivarLugarCommandHandler(ILugarUseCase lugarUseCase)
        {
            this.lugarUseCase = lugarUseCase;
        }

        public Task<ObjectResponse<LugarResponse>> Handle(ActivarLugarCommand request, CancellationToken cancellationToken)
        {
            var rs = lugarUseCase.ActivarLugar(request);
            return rs;
        }
    }
}
