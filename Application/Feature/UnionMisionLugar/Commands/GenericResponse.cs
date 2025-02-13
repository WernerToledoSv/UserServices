﻿
using Domain.Entities.BaseResponse;
using MediatR;

namespace Application.Feature.UnionMisionLugar.Commands
{
    public class EliminarUnionCommand : IRequest<GenericResponse>
    {
        public int pId { get; set; }
    }
}
