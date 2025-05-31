using Application.Feature.Lugar.Queries;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Lugar;
using MediatR;

namespace Application.Handler.Queries.Lugar
{
    public class BuscarLugarByIdQueryHandler : IRequestHandler<BuscarLugarByIdQuery, ObjectResponse<LugarResponse>>
    {
        private readonly ILugarUseCase lugarUseCase;

        public BuscarLugarByIdQueryHandler(ILugarUseCase lugarUseCase)
        {
            this.lugarUseCase = lugarUseCase;
        }

        public Task<ObjectResponse<LugarResponse>> Handle(BuscarLugarByIdQuery request, CancellationToken cancellationToken)
        {
            var rs = lugarUseCase.BuscarLugarById(request);
            return rs;
        }
    }
}
