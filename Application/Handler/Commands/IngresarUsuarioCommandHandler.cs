using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Feature.Usuario.Commands;
using Domain.Entities.BaseResponse;
using Domain.Entities.UserEntities;
using MediatR;

namespace Application.Handler.Commands
{
    public class IngresarUsuarioCommandHandler : IRequestHandler<IngresarUsuarioCommand, ObjectResponse<UsuarioEntity>>
    {
        public Task<ObjectResponse<UsuarioEntity>> Handle(IngresarUsuarioCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}