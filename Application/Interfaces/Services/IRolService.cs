
using Application.Feature.Rol.Commands;
using Application.Feature.Rol.Queries;
using Domain.Entities.Services.Rol;

namespace Application.Interfaces.Services
{
    public interface IRolService
    {
        Task<IList<RolResponse>> ObtenerRoles();
        Task<RolResponse> AgregarRol(AgregarRolCommand rq);
        Task<RolResponse> ActualizarRol(ActualizarRolCommand rq);
        Task<RolResponse> EliminarRol(EliminarRolCommand rq);
        Task<RolResponse> BuscaRolById(BuscarRolByIdQuery rq);
        Task<RolResponse> ActivarRol(ActivarRolCommand rq);
        Task<IList<RolResponse>> BuscarRolByNombre(BuscarRolByNombreQuery rq);
    }
}
