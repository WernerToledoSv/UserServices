
using Application.Feature.Lugar.Commands;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Lugar;
using MediatR;

namespace Application.Handler.Commands
{
    public class ActualizarLugarCommandHandler : IRequestHandler<ActualizarLugarCommand, ObjectResponse<LugarResponse>>
    {
        private readonly ILugarUseCase lugarUseCase;

        public ActualizarLugarCommandHandler(ILugarUseCase lugarUseCase)
        {
            this.lugarUseCase = lugarUseCase;
        }

        public async Task<ObjectResponse<LugarResponse>> Handle(ActualizarLugarCommand request, CancellationToken cancellationToken)
        {
            var rs = await lugarUseCase.ActualizarLugar(request);
            return rs;
        }
    }
}
