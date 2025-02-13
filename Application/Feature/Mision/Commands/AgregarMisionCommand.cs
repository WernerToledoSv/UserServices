using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Mision;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Feature.Mision.Commands
{
    public class AgregarMisionCommand : IRequest<ObjectResponse<MisionResponse>>
    {
        [Required]
        public string pNombre { get; set; }
        [Required]
        public DateTime pFechaInicio { get; set; }
        [Required]
        public DateTime pFechaFin { get; set; }
        public string pDescripcion { get; set; }
        [Required]
        public string pMision { get; set; }
        [Required]
        public string pVision { get; set; }
    }
}
