
using Domain.Entities.BaseResponse;
using MediatR;

namespace Application.Feature.UnionMisionLugar.Commands
{
    public class AgregarUnionCommand : IRequest<GenericResponse>
    {
        public int pIdLugar { get; set; }
        public int pIdMision { get; set; }
    }
}
