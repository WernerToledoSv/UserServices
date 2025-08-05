using Domain.Entities.BaseResponse;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Feature.Paciente.Commands
{
    public class EstadoAtendidoCommand : IRequest<GenericResponse>
    {
        [Required(ErrorMessage = "El campo idpaciente es requerido")]
        public long Id { get; set; }
    }
}
