﻿
using Domain.Entities.BaseResponse;
using MediatR;

namespace Application.Feature.UnionMisionLugar.Commands
{
    public class AgregarUnionCommand : IRequest<GenericResponse>
    {
        public long pIdLugar { get; set; }
        public long pIdMision { get; set; }
    }
}
