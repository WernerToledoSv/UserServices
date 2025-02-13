
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Lugar;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Feature.Lugar.Commands
{
    public class ActivarLugarCommand : IRequest<ObjectResponse<LugarResponse>>
    {
        [Required(ErrorMessage = "El campo pId es obligatorio")]
        public int pId { get; set; }
    }
}
