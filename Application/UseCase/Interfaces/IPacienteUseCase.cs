using Application.Feature.Paciente.Commands;
using Application.Feature.Paciente.Queries;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Paciente;

namespace Application.UseCase.Interfaces
{
    public interface IPacienteUseCase
    {
        #region Commands
        Task<GenericResponse> CrearPaciente(CrearPacienteCommand rq);
        Task<GenericResponse> EditarPaciente(EditarPacienteCommand rq);
        Task<GenericResponse> EstadoAtendido(EstadoAtendidoCommand rq);
        #endregion

        #region Queries
        Task<ListResponse<PacienteResponse>> ObtenerPacienteByLugar(ObtenerPacienteByLugarQuery rq);
        Task<ListResponse<PacienteResponse>> ObtenerPacienteByNombre(ObtenerPacienteByNombreQuery rq);
        #endregion
    }
}
