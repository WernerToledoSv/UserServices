using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Mision;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Feature.Mision.Commands
{
    public class CancelarMisionCommand : IRequest<ObjectResponse<MisionResponse>>
    {
        [Required]
        public int pId { get; set; }
    }
}
