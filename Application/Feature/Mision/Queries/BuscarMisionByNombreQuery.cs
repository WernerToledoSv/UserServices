using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Mision;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Feature.Mision.Queries
{
    public class BuscarMisionByNombreQuery : IRequest<ListResponse<MisionResponse>>
    {
        [Required]
        public string pNombre { get; set; }
    }
}
