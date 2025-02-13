
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Lugar;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Feature.Lugar.Commands
{
    public class AgregarLugarCommand : IRequest<ObjectResponse<LugarResponse>>
    {
        [Required(ErrorMessage = "El campo pNombre es obligatorio")]
        public string pNombre { get; set; }
        [Required(ErrorMessage = "El campo pHoraInicio es obligatorio")]
        public TimeSpan pHoraInicio { get; set; }
        [Required(ErrorMessage = "El campo pHoraFin es obligatorio")]
        public TimeSpan pHoraFin { get; set; }
    }
}
