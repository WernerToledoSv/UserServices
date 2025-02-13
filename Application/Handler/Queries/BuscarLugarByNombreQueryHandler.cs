
using Application.Feature.Lugar.Queries;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Lugar;
using MediatR;

namespace Application.Handler.Queries
{
    public class BuscarLugarByNombreQueryHandler : IRequestHandler<BuscarLugarByNombreQuery, ListResponse<LugarResponse>>
    {
        private readonly ILugarUseCase lugarUseCase;

        public BuscarLugarByNombreQueryHandler(ILugarUseCase lugarUseCase)
        {
            this.lugarUseCase = lugarUseCase;
        }

        public Task<ListResponse<LugarResponse>> Handle(BuscarLugarByNombreQuery request, CancellationToken cancellationToken)
        {
            var rs = lugarUseCase.BuscarLugarByNombre(request);
            return rs;
        }
    }
}
