using Application.Feature.Paciente.Commands;
using Domain.Entities.Services.Paciente;

namespace Application.Interfaces.Services
{
    public interface IPacienteService
    {
        Task<bool> CrearPaciente(CrearPacienteCommand rq);
        Task<bool> EditarPaciente(EditarPacienteCommand rq);
        Task<bool> EstadoAtendido(long idPaciente);
        Task<IList<PacienteResponse>> ObtenerPacienteByLugar(long idLugar);
        Task<PacienteResponse> ObtenerPacienteById(long idPaciente);
        Task<IList<PacienteResponse>> ObtenerPacienteByNombre(string nombreLugar);
        Task<PacienteResponse> ObtenerPacienteByNombreIgual(string nombrePaciente);
    }
}
