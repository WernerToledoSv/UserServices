
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;
using MediatR;

namespace Application.Feature.Usuario.Commands
{
    public class ActivarUsuarioCommand : IRequest<ObjectResponse<UsuarioResponse>>
    {
        public long pId { get; set; }
    }
}
