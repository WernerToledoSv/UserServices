
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Lugar;
using MediatR;

namespace Application.Feature.Lugar.Commands
{
    public class ActualizarLugarCommand : IRequest<ObjectResponse<LugarResponse>>
    {
        public long pId { get; set; }
        public string pNombre { get; set; }
        public DateTime pFecha { get; set; }
        public TimeSpan pHoraInicio { get; set; }
        public TimeSpan pHoraFin { get; set; }
    }
}
