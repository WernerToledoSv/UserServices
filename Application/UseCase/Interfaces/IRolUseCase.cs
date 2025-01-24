
using Application.Feature.Rol.Commands;
using Application.Feature.Rol.Queries;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Rol;

namespace Application.UseCase.Interfaces
{
    public interface IRolUseCase
    {
        Task<ListResponse<RolResponse>> ObtenerRoles();
        Task<ObjectResponse<RolResponse>> AgregarRol(AgregarRolCommand rq);
        Task<ObjectResponse<RolResponse>> ActualizarRol(ActualizarRolCommand rq);
        Task<ObjectResponse<RolResponse>> EliminarRol(EliminarRolCommand rq);
        Task<ObjectResponse<RolResponse>> ActivarRol(ActivarRolCommand rq);
        Task<ObjectResponse<RolResponse>> BuscarRolById(BuscarRolByIdQuery rq);
        Task<ListResponse<RolResponse>> BuscarRolByNombre(BuscarRolByNombreQuery rq);

    }
}
