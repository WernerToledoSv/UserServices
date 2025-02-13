using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Mision;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Feature.Mision.Queries
{
    public class BuscarMisionByIdQuery : IRequest<ObjectResponse<MisionResponse>>
    {
        [Required]
        public int pId { get; set; }
    }
}
