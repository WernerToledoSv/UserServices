using Application.Feature.Lugar.Commands;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Lugar;
using MediatR;

namespace Application.Handler.Commands.Lugar
{
    public class EliminarLugarCommandHandler : IRequestHandler<EliminarLugarCommand, ObjectResponse<LugarResponse>>
    {
        private readonly ILugarUseCase lugarUseCase;

        public EliminarLugarCommandHandler(ILugarUseCase lugarUseCase)
        {
            this.lugarUseCase = lugarUseCase;
        }

        public async Task<ObjectResponse<LugarResponse>> Handle(EliminarLugarCommand request, CancellationToken cancellationToken)
        {
            var rs = await lugarUseCase.EliminarLugar(request);
            return rs;
        }
    }
}
