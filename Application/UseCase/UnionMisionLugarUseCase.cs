using Application.Feature.UnionMisionLugar.Commands;
using Application.Interfaces.Services;
using Application.UseCase.Interfaces;
using Domain.Entities.BaseResponse;
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
            else
            {
                return new GenericResponse()
                {
                    Code = 1,
                    Message = "Error en la operación"
                };
            }
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
            else
            {
                return new GenericResponse()
                {
                    Code = 1,
                    Message = "Error en la operación"
                };
            }
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
            else
            {
                return new GenericResponse()
                {
                    Code = 1,
                    Message = "Error en la operación"
                };
            }
        }
    }
}
