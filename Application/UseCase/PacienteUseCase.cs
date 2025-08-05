using Application.Feature.Paciente.Commands;
using Application.Feature.Paciente.Queries;
using Application.Interfaces.Services;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Paciente;

namespace Application.UseCase
{
    public class PacienteUseCase : IPacienteUseCase
    {
        private readonly IPacienteService _pacienteService;

        public PacienteUseCase(IPacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }

        public async Task<GenericResponse> CrearPaciente(CrearPacienteCommand rq)
        {
            var response = new GenericResponse
            {
                Code = 0,
                Message = "No se pudó agregar el paciente"
            };
            rq.Nombres = rq.Nombres.Trim().ToUpper();
            rq.Apellidos= rq.Apellidos.Trim().ToUpper();
            string nombreCompleto = string.Concat(rq.Nombres, " ",rq.Apellidos);

            //Valida los duplicados
            var bandExistePaciente = await _pacienteService.ObtenerPacienteByNombreIgual(nombreCompleto);
            if (bandExistePaciente != null)
                throw new Exception($"El paciente { nombreCompleto } ya existe");

            var rs = await _pacienteService.CrearPaciente(rq);
            if (rs)
            {
                response.Code = 1;
                response.Message = "Exito en el proceso de agregacion del paciente";
            }
            return response;
        }

        public async Task<GenericResponse> EditarPaciente(EditarPacienteCommand rq)
        {
            var response = new GenericResponse
            {
                Code = 0,
                Message = "No se pudó agregar el paciente"
            };

            //Validacion si existe el paciente
            var existePacienteById = await _pacienteService.ObtenerPacienteById(rq.Id);
            if (existePacienteById == null)
                throw new Exception("No existe el paciente");

            //une el nombre completo
            rq.Nombres = rq.Nombres.Trim().ToUpper();
            rq.Apellidos = rq.Apellidos.Trim().ToUpper();
            string nombreCompleto = string.Concat(rq.Nombres, rq.Apellidos);

            //Valida los duplicados
            var bandExistePaciente = await _pacienteService.ObtenerPacienteByNombreIgual(nombreCompleto);
            if (bandExistePaciente != null)
                throw new Exception($"El paciente {nombreCompleto} ya existe");

            var rs = await _pacienteService.EditarPaciente(rq);
            if (rs)
            {
                response.Code = 1;
                response.Message = "Exito en el proceso de edición del paciente";
            }
            return response;
        }

        public async Task<GenericResponse> EstadoAtendido(EstadoAtendidoCommand rq)
        {
            var response = new GenericResponse
            {
                Code = 0,
                Message = "No se pudó agregar el paciente"
            };

            //Validacion si existe el paciente
            var existePacienteById = await _pacienteService.ObtenerPacienteById(rq.Id);
            if (existePacienteById == null)
                throw new Exception("No existe el paciente");

            var rs = await _pacienteService.EstadoAtendido(rq.Id);

            if (rs) 
            {
                response = new GenericResponse
                {
                    Code = 1,
                    Message = "Paciente atendido"
                };
            }

            return response;
        }

        public async Task<ListResponse<PacienteResponse>> ObtenerPacienteByLugar(ObtenerPacienteByLugarQuery rq)
        {
            var response = new ListResponse<PacienteResponse>
            {
                Code = 0,
                Message = "No existen datos"
            };

            var rs = await _pacienteService.ObtenerPacienteByLugar(rq.IdLugar);

            if (rs.Any())
            {
                response.Code = 1;
                response.Message = "Exito en la obtencion de datos";
                response.Items = rs;
            }
            return response;
        }

        public async Task<ListResponse<PacienteResponse>> ObtenerPacienteByNombre(ObtenerPacienteByNombreQuery rq)
        {
            var response = new ListResponse<PacienteResponse>
            {
                Code = 0,
                Message = "No existen datos"
            };

            rq.Nombre = rq.Nombre.Trim().ToUpper();
            var rs = await _pacienteService.ObtenerPacienteByNombre(rq.Nombre);
            if (rs.Any())
            {
                response.Code = 1;
                response.Message = "Exito en la obtencion de datos";
                response.Items = rs;

            }
            return response;
        }
    }
}
