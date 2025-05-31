using Application.Feature.UnionMisionLugar.Commands;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using MediatR;

namespace Application.Handler.Commands.UnionMisionLugar
{
    public class ActualizarUnionCommandHandler : IRequestHandler<ActualizarUnionCommand, GenericResponse>
    {
        private readonly IUnionMisionLugarUseCase unionMisionLugarUseCase;

        public ActualizarUnionCommandHandler(IUnionMisionLugarUseCase unionMisionLugarUseCase)
        {
            this.unionMisionLugarUseCase = unionMisionLugarUseCase;
        }

        public Task<GenericResponse> Handle(ActualizarUnionCommand request, CancellationToken cancellationToken)
        {
            var rs = unionMisionLugarUseCase.ActualizarUnion(request);
            return rs;
        }
    }
}
