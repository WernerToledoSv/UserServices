using Application.Feature.UnionMisionLugar.Commands;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using MediatR;

namespace Application.Handler.Commands
{
    public class EliminarUnionCommandHandler : IRequestHandler<EliminarUnionCommand, GenericResponse>
    {
        public readonly IUnionMisionLugarUseCase unionMisionLugarUseCase;

        public EliminarUnionCommandHandler(IUnionMisionLugarUseCase unionMisionLugarUseCase)
        {
            this.unionMisionLugarUseCase = unionMisionLugarUseCase;
        }

        public async Task<GenericResponse> Handle(EliminarUnionCommand request, CancellationToken cancellationToken)
        {
            var rs = await unionMisionLugarUseCase.EliminarUnion(request);
            return rs;
        }
    }
}
