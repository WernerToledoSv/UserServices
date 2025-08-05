using Application.Feature.Paciente.Commands;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using MediatR;

namespace Application.Handler.Commands.Paciente
{
    public class EstadoAtendidoCommandHandler :IRequestHandler<EstadoAtendidoCommand, GenericResponse>
    {
        private readonly IPacienteUseCase _pacienteUseCase;

        public EstadoAtendidoCommandHandler(IPacienteUseCase pacienteUseCase)
        {
            _pacienteUseCase = pacienteUseCase;
        }

        public async Task<GenericResponse> Handle(EstadoAtendidoCommand request, CancellationToken cancellationToken)
        {
            return await _pacienteUseCase.EstadoAtendido(request);
        }
    }
}
