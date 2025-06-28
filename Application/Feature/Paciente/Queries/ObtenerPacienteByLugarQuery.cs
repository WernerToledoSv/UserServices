using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Paciente;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Feature.Paciente.Queries
{
    public class ObtenerPacienteByLugarQuery : IRequest<ListResponse<PacienteResponse>>
    {
        [Required(ErrorMessage = "El campo IdLugar es obligatorio")]
        public long IdLugar { get; set; }   
    }
}
