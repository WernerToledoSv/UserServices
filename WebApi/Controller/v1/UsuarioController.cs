using Application.Feature.User.Queries;
using Application.Feature.Usuario.Commands;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Queries;
using Domain.Entities.Services.Queries.UserEntities;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controller.v1;

public class UsuarioController : BaseApiController
{

    [HttpGet("ListadoUsuario")]
    [ProducesResponseType(typeof(ListResponse<UsuarioEntity>), 200)]
    [ProducesResponseType(typeof(GenericResponse), 500)]
    public async Task<IActionResult> ObtenerUsuario()
    {
        var rs = await Mediator.Send(new ObtenerUsuarioQuery());
        return Ok(rs);
    }
}