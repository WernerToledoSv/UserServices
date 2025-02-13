
using Application.Feature.Rol.Commands;
using Application.Feature.Rol.Queries;
using Application.Interfaces.Services;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Rol;

namespace Application.UseCase
{
    public class RolUseCase : IRolUseCase
    {
        #region Atributos
        private readonly IRolService _service;
        #endregion

        #region Constructor
        public RolUseCase(IRolService service)
        {
            _service = service;
        }
        #endregion

        #region Metodos
        public async Task<ObjectResponse<RolResponse>> ActivarRol(ActivarRolCommand rq)
        {
            var respose = new ObjectResponse<RolResponse>();
            var rs = await _service.ActivarRol(rq);

            if (rs.Id != null)
            {
                respose = new ObjectResponse<RolResponse>
                {
                    Code = 1,
                    Message = "Exito en el activar el rol",
                    Item = rs
                };
            }
            else
            {
                respose = new ObjectResponse<RolResponse>
                {
                    Code = 0,
                    Message = "Error en la activación del rol",
                    Item = null
                };
            }
            return respose;
        }

        public async Task<ObjectResponse<RolResponse>> ActualizarRol(ActualizarRolCommand rq)
        {
            var respose = new ObjectResponse<RolResponse>();
            var rs = await _service.ActualizarRol(rq);

            if (rs.Id != null)
            {
                respose = new ObjectResponse<RolResponse>
                {
                    Code = 1,
                    Message = "Exito en la actualización del rol",
                    Item = rs
                };
            }
            else
            {
                respose = new ObjectResponse<RolResponse>
                {
                    Code = 0,
                    Message = "Error En la actualización del rol",
                    Item = null
                };
            }
            return respose;
        }

        public async Task<ObjectResponse<RolResponse>> AgregarRol(AgregarRolCommand rq)
        {
            var respose = new ObjectResponse<RolResponse>();
            var rs = await _service.AgregarRol(rq);

            if (rs.Id != null)
            {
                respose = new ObjectResponse<RolResponse>
                {
                    Code = 1,
                    Message = "Exito al agregar",
                    Item = rs
                };
            }
            else
            {
                respose = new ObjectResponse<RolResponse>
                {
                    Code = 0,
                    Message = "Error En la insercion del rol",
                    Item = null
                };
            }
            return respose;
        }

        public async Task<ObjectResponse<RolResponse>> BuscarRolById(BuscarRolByIdQuery rq)
        {
            var response = new ObjectResponse<RolResponse>();
            var rs = await _service.BuscaRolById(rq);

            if (rs != null)
            {
                response = new ObjectResponse<RolResponse>
                {
                    Code = 1,
                    Message = "Exito al encontrar el rol por id",
                    Item = rs
                };
            }
            else
            {
                response = new ObjectResponse<RolResponse>
                {
                    Code = 1,
                    Message = "No existen datos",
                    Item = null
                };
            }
            return response;
        }

        public async Task<ObjectResponse<RolResponse>> EliminarRol(EliminarRolCommand rq)
        {
            var respose = new ObjectResponse<RolResponse>();
            var rs = await _service.EliminarRol(rq);

            if (rs.Id != null)
            {
                respose = new ObjectResponse<RolResponse>
                {
                    Code = 1,
                    Message = "Exito en el eliminar el rol",
                    Item = rs
                };
            }
            else
            {
                respose = new ObjectResponse<RolResponse>
                {
                    Code = 0,
                    Message = "Error en la eliminación del rol",
                    Item = null
                };
            }
            return respose;
        }

        public async Task<ListResponse<RolResponse>> BuscarRolByNombre(BuscarRolByNombreQuery rq)
        {
            var response = new ListResponse<RolResponse>();
            var rs = await _service.BuscarRolByNombre(rq);

            if (rs.Count > 0)
            {
                response = new ListResponse<RolResponse>
                {
                    Code = 1,
                    Message = "Exito en la obtenecion de los roles por nombre",
                    Items = rs
                };
            }
            else
            {
                response = new ListResponse<RolResponse>
                {
                    Code = 0,
                    Message = "No existen datos",
                    Items = null
                };
            }
            return response;
        }

        public async Task<ListResponse<RolResponse>> ObtenerRoles()
        {
            var response = new ListResponse<RolResponse>();
            var rs = await _service.ObtenerRoles();


            if (rs.Count > 0)
            {
                response = new ListResponse<RolResponse>
                {
                    Code = 1,
                    Message = "Exito en la obtenecion de los roles",
                    Items = rs
                };
            }
            else
            {
                response = new ListResponse<RolResponse>
                {
                    Code = 0,
                    Message = "No existen datos",
                    Items = null
                };
            }
            return response;
        }
        #endregion
    }
}
