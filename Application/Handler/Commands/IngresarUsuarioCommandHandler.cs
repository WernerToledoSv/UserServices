using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Feature.Usuario.Commands;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Queries.UserEntities;
using MediatR;

namespace Application.Handler.Commands
{
    public class IngresarUsuarioCommandHandler : IRequestHandler<IngresarUsuarioCommand, ObjectResponse<UsuarioEntity>>
    {
        private readonly IUsuarioUseCase usuarioUseCase;

        public IngresarUsuarioCommandHandler(IUsuarioUseCase usuarioUseCase)
        {
            this.usuarioUseCase = usuarioUseCase;
        }

        public async Task<ObjectResponse<UsuarioEntity>> Handle(IngresarUsuarioCommand request, CancellationToken cancellationToken)
        {
            var rs = await usuarioUseCase.AgregarUsuario(request);
            return rs;
        }
    }
}