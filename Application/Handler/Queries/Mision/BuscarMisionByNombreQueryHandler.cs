using Application.Feature.Mision.Queries;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Mision;
using MediatR;

namespace Application.Handler.Queries.Mision
{
    public class BuscarMisionByNombreQueryHandler : IRequestHandler<BuscarMisionByNombreQuery, ListResponse<MisionResponse>>
    {
        private readonly IMisionUseCase misionUseCase;

        public BuscarMisionByNombreQueryHandler(IMisionUseCase misionUseCase)
        {
            this.misionUseCase = misionUseCase;
        }

        public Task<ListResponse<MisionResponse>> Handle(BuscarMisionByNombreQuery request, CancellationToken cancellationToken)
        {
            var rs = misionUseCase.BuscarMisionByNombre(request);
            return rs;
        }
    }
}
