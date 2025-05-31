using Application.Feature.UnionMisionLugar.Queries;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.UnionMisionLugar;
using MediatR;

namespace Application.Handler.Queries.UnionMisionLugar
{
    public class ListadoUnionQueryHandler : IRequestHandler<ListadoUnionQuery, ListResponse<ListadoUnionResponse>>
    {
        private IUnionMisionLugarUseCase _unionMisionLugarUseCase;

        public ListadoUnionQueryHandler(IUnionMisionLugarUseCase unionMisionLugarUseCase)
        {
            _unionMisionLugarUseCase = unionMisionLugarUseCase;
        }

        public Task<ListResponse<ListadoUnionResponse>> Handle(ListadoUnionQuery request, CancellationToken cancellationToken)
        {
            var rs = _unionMisionLugarUseCase.ListadoUnion();
            return rs;
        }
    }
}
