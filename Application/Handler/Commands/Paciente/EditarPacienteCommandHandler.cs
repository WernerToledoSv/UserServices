using Application.Feature.Paciente.Commands;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using MediatR;

namespace Application.Handler.Commands.Paciente
{
    public class EditarPacienteCommandHandler  : IRequestHandler<EditarPacienteCommand, GenericResponse>
    {
        private readonly IPacienteUseCase _pacienteUseCase;

        public EditarPacienteCommandHandler(IPacienteUseCase pacienteUseCase)
        {
            _pacienteUseCase = pacienteUseCase;
        }

        public async Task<GenericResponse> Handle(EditarPacienteCommand request, CancellationToken cancellationToken)
        {
            return await _pacienteUseCase.EditarPaciente(request);
        }
    }
}
