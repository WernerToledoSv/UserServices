

using Domain.Entities.BaseResponse;
using MediatR;

namespace Application.Feature.UnionMisionLugar.Commands
{
    public class ActualizarUnionCommand : IRequest<GenericResponse>
    {
        public long pId { get; set; }
        public long pIdLugar { get; set; }
        public long pIdMision { get; set; }
    }
}
