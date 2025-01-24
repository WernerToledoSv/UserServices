
using Application.Feature.Lugar.Queries;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Lugar;
using MediatR;

namespace Application.Handler.Queries
{
    public class ObtenerLugarQueryHandler : IRequestHandler<ObtenerLugarQuery, ListResponse<LugarResponse>>
    {
        private readonly ILugarUseCase _useCase;

        public ObtenerLugarQueryHandler(ILugarUseCase useCase)
        {
            _useCase = useCase;
        }

        public async Task<ListResponse<LugarResponse>> Handle(ObtenerLugarQuery request, CancellationToken cancellationToken)
        {
            var rs = await _useCase.ObtenerLugar();
            return rs;
        }
    }
}
