using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Mision;
using MediatR;

namespace Application.Feature.Mision.Commands
{
    public class ActivarMisionCommand : IRequest<ObjectResponse<MisionResponse>>
    {
        public long pId {  get; set; } 
    }
}
