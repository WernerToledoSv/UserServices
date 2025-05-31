using Application.Feature.Mision.Queries;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Mision;
using MediatR;

namespace Application.Handler.Queries.Mision
{
    public class ListadoMisionQueryHandler : IRequestHandler<ListadoMisionQuery, ListResponse<MisionResponse>>
    {
        private readonly IMisionUseCase misionUseCase;

        public ListadoMisionQueryHandler(IMisionUseCase misionUseCase)
        {
            this.misionUseCase = misionUseCase;
        }

        public Task<ListResponse<MisionResponse>> Handle(ListadoMisionQuery request, CancellationToken cancellationToken)
        {
            var rs = misionUseCase.ListadoMision();
            return rs;
        }
    }
}
