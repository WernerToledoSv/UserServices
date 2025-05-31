using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Mision;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Feature.Mision.Commands
{
    public class CambiarEstadoMisionCommand : IRequest<ObjectResponse<MisionResponse>>
    {
        [Required]
        public long pId { get; set; }
        [Required]
        public string pEstado { get; set; }
    }
}
