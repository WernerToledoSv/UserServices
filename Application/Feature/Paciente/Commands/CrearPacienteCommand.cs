using Domain.Entities.BaseResponse;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Feature.Paciente.Commands
{
    public class CrearPacienteCommand : IRequest<GenericResponse>
    {
        [Required(ErrorMessage = "El campo Nombres es obligatorio.")]
        [StringLength(255, ErrorMessage = "El campo Nombres no puede exceder los 255 caracteres.")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El campo Apellidos es obligatorio.")]
        [StringLength(255, ErrorMessage = "El campo Apellidos no puede exceder los 255 caracteres.")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "La edad es obligatoria.")]
        [Range(1, 90, ErrorMessage = "La edad debe estar entre 0 y 90 años.")]
        public long Edad { get; set; }

        [Required(ErrorMessage = "El campo Sexo es obligatorio.")]
        public string Sexo { get; set; } // Si tienes un enum en C#, se puede cambiar a un tipo enumerado.

        [StringLength(8, ErrorMessage = "El número de celular no puede exceder los 8 caracteres.")]
        public string? Cel { get; set; }

        [StringLength(1000, ErrorMessage = "La dirección no puede exceder los 1000 caracteres.")]
        public string? Direccion { get; set; }

        [Required(ErrorMessage = "El campo de IdLugar es obligatorio.")]
        public long IdLugar { get; set; }

        [Required(ErrorMessage = "El campo de tipoconsulta es obligatorio.")]
        public string tipoconsulta { get; set; }

        [Required(ErrorMessage = "El campo de tipopaciente es obligatorio.")]
        public string tipopaciente { get; set; }
    }
}
