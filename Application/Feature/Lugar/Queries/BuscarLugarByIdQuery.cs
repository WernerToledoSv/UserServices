
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Lugar;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Feature.Lugar.Queries
{
    public class BuscarLugarByIdQuery : IRequest<ObjectResponse<LugarResponse>>
    {
        [Required(ErrorMessage = "EL campo pId es obligatorio")]
        public int pId { get; set; }
    }
}
