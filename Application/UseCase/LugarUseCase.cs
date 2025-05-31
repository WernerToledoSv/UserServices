
using Application.Feature.Lugar.Commands;
using Application.Feature.Lugar.Queries;
using Application.Interfaces.Services;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Lugar;

namespace Application.UseCase
{
    public class LugarUseCase : ILugarUseCase
    {
        #region Atributos
        private readonly ILugarService _service;
        #endregion

        #region Constructor
        public LugarUseCase(ILugarService service)
        {
            _service = service;
        }
        #endregion

        #region Metodos
        public async Task<ObjectResponse<LugarResponse>> ActivarLugar(ActivarLugarCommand rq)
        {
            var response = new ObjectResponse<LugarResponse>();
            var rs = await _service.ActivarLugar(rq);

            if (rs.Nombre != null)
            {
                response = new ObjectResponse<LugarResponse>
                {
                    Code = 1,
                    Message = "Exito en la activacion del lugar",
                    Item = rs
                };
            }
            else
            {
                response = new ObjectResponse<LugarResponse>
                {
                    Code = 0,
                    Message = "Error, no se encontró registro",
                    Item = null
                };
            }
            return response;
        }

        public async Task<ObjectResponse<LugarResponse>> ActualizarLugar(ActualizarLugarCommand rq)
        {
            var response = new ObjectResponse<LugarResponse>();
            var rs = await _service.ActualizarLugar(rq);

            if (rs.Nombre != null)
            {
                response = new ObjectResponse<LugarResponse>
                {
                    Code = 1,
                    Message = "Exito en la actualizacion de lugar",
                    Item = rs
                };
            }
            else
            {
                response = new ObjectResponse<LugarResponse>
                {
                    Code = 1,
                    Message = "Error, no se encontró registro",
                    Item = null
                };
            }
            return response;
        }

        public async Task<ObjectResponse<LugarResponse>> AgregarLugar(AgregarLugarCommand rq)
        {
            var response = new ObjectResponse<LugarResponse>();

            var rs = await _service.AgregarLugar(rq);

            if (rs != null)
            {
                response = new ObjectResponse<LugarResponse>
                {
                    Code = 1,
                    Message = "Exito al agregar el lugar",
                    Item = rs
                };
            }
            else
            {
                response = new ObjectResponse<LugarResponse>
                {
                    Code = 0,
                    Message = "Error al ingresar los datos",
                    Item = null
                };
            }

            return response;
        }

        public async Task<ObjectResponse<LugarResponse>> BuscarLugarById(BuscarLugarByIdQuery rq)
        {
            var response = new ObjectResponse<LugarResponse>();

            var rs = await _service.BuscarLugarById(rq);

            if (rs != null)
            {
                response = new ObjectResponse<LugarResponse>
                {
                    Code = 1,
                    Message = "Exito al encontrar el lugar por el id",
                    Item = rs
                };
            }
            else
            {
                response = new ObjectResponse<LugarResponse>
                {
                    Code = 0,
                    Message = "Error, no se encontró registro",
                    Item = null
                };
            }

            return response;
        }

        public async Task<ListResponse<LugarResponse>> BuscarLugarByNombre(BuscarLugarByNombreQuery rq)
        {
            var response = new ListResponse<LugarResponse>();
            var rs = await _service.BuscarLugarByNombre(rq);

            if (rs[0].Id != 0)
            {
                response = new ListResponse<LugarResponse>
                {
                    Code = 1,
                    Message = "Exito en la obtencion de datos",
                    Items = rs
                };
            }
            else
            {
                response = new ListResponse<LugarResponse>
                {
                    Code = 0,
                    Message = "Error, no se encontraron registros",
                    Items = null
                };
            }
            return response;
        }

        public async Task<ObjectResponse<LugarResponse>> EliminarLugar(EliminarLugarCommand rq)
        {
            var response = new ObjectResponse<LugarResponse>();
            var rs = await _service.EliminarLugar(rq);

            if (rs.Nombre != null)
            {
                response = new ObjectResponse<LugarResponse>
                {
                    Code = 1,
                    Message = "Exito al eliminar el lugar",
                    Item = rs
                };
            }
            else
            {
                response = new ObjectResponse<LugarResponse>
                {
                    Code = 0,
                    Message = "Error, no se encontro registro",
                    Item = null
                };
            }
            return response;
        }

        public async Task<ListResponse<LugarResponse>> ObtenerLugar()
        {
            var response = new ListResponse<LugarResponse>();
            var rs = await _service.ObtenerLugar();

            if (rs[0].Id != 0)
            {
                response = new ListResponse<LugarResponse>
                {
                    Code = 1,
                    Message = "Exito en la obtencion de datos",
                    Items = rs
                };
            }
            else
            {
                response = new ListResponse<LugarResponse>
                {
                    Code = 0,
                    Message = "Error, no se encontraron registros",
                    Items = null
                };
            }
            return response;
        }
        #endregion
    }
}
