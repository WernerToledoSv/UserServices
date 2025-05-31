
using Application.Feature.Mision.Commands;
using Application.Feature.Mision.Queries;
using Application.Interfaces.Services;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Mision;

namespace Application.UseCase
{
    public class MisionUseCase : IMisionUseCase
    {
        private readonly IMisionService _service;

        public MisionUseCase(IMisionService service)
        {
            _service = service;
        }

        #region Commands
        public async Task<ObjectResponse<MisionResponse>> CancelarMision(CancelarMisionCommand rq)
        {
            var response = new ObjectResponse<MisionResponse>();

            var rs = await _service.CancelarMision(rq);
            if (rs != null)
            {
                response = new ObjectResponse<MisionResponse>()
                {
                    Code = 1,
                    Message = "Exito en el proceso",
                    Item = rs
                };
            }
            else
            {
                response = new ObjectResponse<MisionResponse>()
                {
                    Code = 0,
                    Message = "Error, no se encontró registro",
                    Item = null
                };
            }
            return response;
        }

        public async Task<ObjectResponse<MisionResponse>> CambiarEstadoMision(CambiarEstadoMisionCommand rq)
        {
            var response = new ObjectResponse<MisionResponse>();

            var rs = await _service.CambiarEstadoMision(rq);
            if (rs != null)
            {
                response = new ObjectResponse<MisionResponse>()
                {
                    Code = 1,
                    Message = "Exito en el proceso",
                    Item = rs
                };
            }
            else
            {
                response = new ObjectResponse<MisionResponse>()
                {
                    Code = 0,
                    Message = "Error, no se encontró registro",
                    Item = null
                };
            }
            return response;
        }

        public async Task<ObjectResponse<MisionResponse>> ActualizarMision(ActualizarMisionCommand rq)
        {
            var response = new ObjectResponse<MisionResponse>();

            var rs = await _service.ActualizarMision(rq);
            if (rs != null)
            {
                response = new ObjectResponse<MisionResponse>()
                {
                    Code = 1,
                    Message = "Exito en el proceso",
                    Item = rs
                };
            }
            else
            {
                response = new ObjectResponse<MisionResponse>()
                {
                    Code = 0,
                    Message = "Error, no se encontró registro",
                    Item = null
                };
            }
            return response;
        }

        public async Task<ObjectResponse<MisionResponse>> AgregarMision(AgregarMisionCommand rq)
        {
            var response = new ObjectResponse<MisionResponse>();

            var rs = await _service.AgregarMision(rq);
            if (rs != null)
            {
                response = new ObjectResponse<MisionResponse>()
                {
                    Code = 1,
                    Message = "Exito en el proceso",
                    Item = rs
                };
            }
            else
            {
                response = new ObjectResponse<MisionResponse>()
                {
                    Code = 0,
                    Message = "Error, no se encontró registro",
                    Item = null
                };
            }
            return response;
        }
        #endregion

        #region Queries
        public async Task<ObjectResponse<MisionResponse>> BuscarMisionByid(BuscarMisionByIdQuery rq)
        {
            var response = new ObjectResponse<MisionResponse>();

            var rs = await _service.BuscarMisionByid(rq);
            if (rs != null)
            {
                response = new ObjectResponse<MisionResponse>()
                {
                    Code = 1,
                    Message = "Exito en el proceso",
                    Item = rs
                };
            }
            else
            {
                response = new ObjectResponse<MisionResponse>()
                {
                    Code = 0,
                    Message = "Error, no se encontró registro",
                    Item = null
                };
            }
            return response;
        }

        public async Task<ListResponse<MisionResponse>> BuscarMisionByNombre(BuscarMisionByNombreQuery rq)
        {
            var response = new ListResponse<MisionResponse>();

            var rs = await _service.BuscarMisionByNombre(rq);
            if (rs.Count > 0 || rs is not null)
            {
                response = new ListResponse<MisionResponse>()
                {
                    Code = 1,
                    Message = "Exito en el proceso",
                    Items = rs
                };
            }
            else
            {
                response = new ListResponse<MisionResponse>()
                {
                    Code = 0,
                    Message = "Error, no se encontraron registros",
                    Items = null
                };
            }
            return response;
        }

        public async Task<ListResponse<MisionResponse>> ListadoMision()
        {
            var response = new ListResponse<MisionResponse>();

            var rs = await _service.ListadoMision();

            if (rs.Count > 0 || rs is not null)
            {
                response = new ListResponse<MisionResponse>()
                {
                    Code = 1,
                    Message = "Exito en el proceso",
                    Items = rs
                };
            }
            else
            {
                response = new ListResponse<MisionResponse>()
                {
                    Code = 0,
                    Message = "Error, no se encontraron registros",
                    Items = null
                };
            }
            return response;
        }

        public async Task<ObjectResponse<MisionResponse>> ActivarMision(ActivarMisionCommand rq)
        {
            var response = new ObjectResponse<MisionResponse>();
            var rs = await _service.ActivarMision(rq);
            if(rs != null)
            {
                response = new ObjectResponse<MisionResponse>()
                {
                    Code = 1,
                    Message = "Exito en el proceso",
                    Item = rs
                };
            }
            else
            {
                response = new ObjectResponse<MisionResponse>()
                {
                    Code = 0,
                    Message = "Error en el proceso",
                    Item = rs
                };
            }
            return response;
        }
        #endregion
    }
}
