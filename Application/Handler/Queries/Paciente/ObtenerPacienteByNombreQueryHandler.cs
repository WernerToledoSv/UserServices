using Application.Feature.Paciente.Queries;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Paciente;
using MediatR;

namespace Application.Handler.Queries.Paciente
{
    public class ObtenerPacienteByNombreQueryHandler : IRequestHandler<ObtenerPacienteByNombreQuery, ListResponse<PacienteResponse>>
    {
        private readonly IPacienteUseCase _pacienteUseCase;

        public ObtenerPacienteByNombreQueryHandler(IPacienteUseCase pacienteUseCase)
        {
            _pacienteUseCase = pacienteUseCase;
        }

        public async Task<ListResponse<PacienteResponse>> Handle(ObtenerPacienteByNombreQuery request, CancellationToken cancellationToken)
        {
            return await _pacienteUseCase.ObtenerPacienteByNombre(request);
        }
    }
}
