
using Application.Feature.Mision.Queries;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Mision;
using MediatR;

namespace Application.Handler.Queries
{
    public class BuscarMisionByIdQueryHandler : IRequestHandler<BuscarMisionByIdQuery, ObjectResponse<MisionResponse>>
    {
        private readonly IMisionUseCase useCase;

        public BuscarMisionByIdQueryHandler(IMisionUseCase useCase)
        {
            this.useCase = useCase;
        }

        public Task<ObjectResponse<MisionResponse>> Handle(BuscarMisionByIdQuery request, CancellationToken cancellationToken)
        {
            var rs = useCase.BuscarMisionByid(request);
            return rs;
        }
    }
}
