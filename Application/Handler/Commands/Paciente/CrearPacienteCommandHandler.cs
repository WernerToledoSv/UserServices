using Application.Feature.Paciente.Commands;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using MediatR;

namespace Application.Handler.Commands.Paciente
{
    public class CrearPacienteCommandHandler : IRequestHandler<CrearPacienteCommand, GenericResponse>
    {
        private readonly IPacienteUseCase _pacienteUseCase;

        public CrearPacienteCommandHandler(IPacienteUseCase pacienteUseCase)
        {
            _pacienteUseCase = pacienteUseCase;
        }

        public async Task<GenericResponse> Handle(CrearPacienteCommand request, CancellationToken cancellationToken)
        {
            return await _pacienteUseCase.CrearPaciente(request);
        }
    }
}
