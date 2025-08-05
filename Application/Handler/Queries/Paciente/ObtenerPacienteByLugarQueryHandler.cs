using Application.Feature.Paciente.Queries;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Paciente;
using MediatR;

namespace Application.Handler.Queries.Paciente
{
    public class ObtenerPacienteByLugarQueryHandler : IRequestHandler<ObtenerPacienteByLugarQuery, ListResponse<PacienteResponse>>
    {
        private readonly IPacienteUseCase _pacienteUseCase;

        public ObtenerPacienteByLugarQueryHandler(IPacienteUseCase pacienteUseCase)
        {
            _pacienteUseCase = pacienteUseCase;
        }

        public async Task<ListResponse<PacienteResponse>> Handle(ObtenerPacienteByLugarQuery request, CancellationToken cancellationToken)
        {
            return await _pacienteUseCase.ObtenerPacienteByLugar(request);
        }
    }
}
