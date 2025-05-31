using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Lugar;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Feature.Lugar.Commands
{
    public class EliminarLugarCommand : IRequest<ObjectResponse<LugarResponse>>
    {
        [Required(ErrorMessage = "El campo pId es obligatorio")]
        public long pId { get; set; }
    }
}
