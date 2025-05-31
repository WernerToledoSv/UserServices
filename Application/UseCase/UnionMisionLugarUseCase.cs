using Application.Feature.UnionMisionLugar.Commands;
using Application.Interfaces.Services;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.UnionMisionLugar;
using Microsoft.AspNetCore.Mvc;

namespace Application.UseCase
{
    public class UnionMisionLugarUseCase : IUnionMisionLugarUseCase
    {
        private readonly IUnionMisionLugarService _service;

        public UnionMisionLugarUseCase(IUnionMisionLugarService service)
        {
            _service = service;
        }

        public async Task<GenericResponse> ActualizarUnion(ActualizarUnionCommand rq)
        {
            var rs = await _service.ActualizarUnion(rq);
            if (rs)
            {
                return new GenericResponse()
                {
                    Code = 1,
                    Message = "Exito en la operación"
                };
            }
            return new GenericResponse()
            {
                Code = 0,
                Message = "Error, no se encontró registro"
            };
        }

        public async Task<GenericResponse> AgregarUnion(AgregarUnionCommand rq)
        {
            var rs = await _service.AgregarUnion(rq);
            if (rs)
            {
                return new GenericResponse()
                {
                    Code = 1,
                    Message = "Exito en la operación"
                };
            }
            return new GenericResponse()
            {
                Code = 0,
                Message = "Los id no coinciden con los registros"
            };
        }

        public async Task<GenericResponse> EliminarUnion(EliminarUnionCommand rq)
        {
            var rs = await _service.EliminarUnion(rq);
            if (rs)
            {
                return new GenericResponse()
                {
                    Code = 1,
                    Message = "Exito en la operación"
                };
            }
            return new GenericResponse()
            {
                Code = 0,
                Message = "Error, no se encontró registro"
            };
            
        }

        public async Task<ListResponse<ListadoUnionResponse>> ListadoUnion()
        {
            var rs = await _service.ListadoUnion();
            if (rs.Any())
            {
                return new ListResponse<ListadoUnionResponse>
                {
                    Code = 1,
                    Message = "Exito en la obtencion de datos",
                    Items = rs
                };
            }

            return new ListResponse<ListadoUnionResponse>
            {
                Code = 0,
                Message = "Error, no se encontraron registros.",
                Items = null
            };
        }
    }
}
