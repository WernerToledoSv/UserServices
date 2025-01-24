
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Rol;
using MediatR;

namespace Application.Feature.Rol.Queries
{
    public class BuscarRolByNombreQuery : IRequest<ListResponse<RolResponse>>
    {
        public string pNombre {  get; set; }
    }
}
