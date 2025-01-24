using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Lugar;
using MediatR;

namespace Application.Feature.Lugar.Commands
{
    public class EliminarLugarCommand : IRequest<ObjectResponse<LugarResponse>>
    {
        public int pId {  get; set; }
    }
}
