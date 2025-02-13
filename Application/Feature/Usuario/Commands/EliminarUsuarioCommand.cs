
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;
using MediatR;

namespace Application.Feature.Usuario.Commands
{
    public class EliminarUsuarioCommand : IRequest<ObjectResponse<UsuarioResponse>>
    {
        public int pId { get; set; }
    }
}
