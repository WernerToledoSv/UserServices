using Application.Feature.Lugar.Commands;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Lugar;
using MediatR;

namespace Application.Handler.Commands.Lugar
{
    public class AgregarLugarCommandHandler : IRequestHandler<AgregarLugarCommand, ObjectResponse<LugarResponse>>
    {
        private readonly ILugarUseCase lugarUseCase;

        public AgregarLugarCommandHandler(ILugarUseCase lugarUseCase)
        {
            this.lugarUseCase = lugarUseCase;
        }

        public async Task<ObjectResponse<LugarResponse>> Handle(AgregarLugarCommand request, CancellationToken cancellationToken)
        {
            var rs = await lugarUseCase.AgregarLugar(request);
            return rs;
        }
    }
}
