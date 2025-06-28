using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Paciente;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Feature.Paciente.Queries
{
    public class ObtenerPacienteByNombreQuery : IRequest<ListResponse<PacienteResponse>>
    {
        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        public string Nombre { get; set; }
    }
}
