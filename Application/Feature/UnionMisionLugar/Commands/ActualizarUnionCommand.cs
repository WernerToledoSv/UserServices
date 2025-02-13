

using Domain.Entities.BaseResponse;
using MediatR;

namespace Application.Feature.UnionMisionLugar.Commands
{
    public class ActualizarUnionCommand : IRequest<GenericResponse>
    {
        public int pId { get; set; }
        public int pIdLugar { get; set; }
        public int pIdMision { get; set; }
    }
}
