
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Lugar;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Feature.Lugar.Queries
{
    public class BuscarLugarByNombreQuery : IRequest<ListResponse<LugarResponse>>
    {
        [Required(ErrorMessage = "EL campo pNombre es obligatorio")]
        public string pNombre { get; set; }
    }
}
