using Application.Feature.UnionMisionLugar.Commands;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using MediatR;

namespace Application.Handler.Commands.UnionMisionLugar
{
    internal class AgregarUnionCommandHandler : IRequestHandler<AgregarUnionCommand, GenericResponse>
    {
        private readonly IUnionMisionLugarUseCase unionMisionLugarUseCase;

        public AgregarUnionCommandHandler(IUnionMisionLugarUseCase unionMisionLugarUseCase)
        {
            this.unionMisionLugarUseCase = unionMisionLugarUseCase;
        }

        public async Task<GenericResponse> Handle(AgregarUnionCommand request, CancellationToken cancellationToken)
        {
            var rs = await unionMisionLugarUseCase.AgregarUnion(request);
            return rs;
        }
    }
}
