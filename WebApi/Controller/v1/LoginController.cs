using Application.Feature.User.Queries;
using Application.Feature.Usuario.Queries;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controller.v1
{
    public class LoginController : BaseApiController
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Validar-Credenciales")]
        [ProducesResponseType(typeof(ObjectResponse<LoginResponse>), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> LoginUsuario([FromQuery] LoginUsuarioQuery rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en el login. {ex.Message}";
                _logger.LogError(ex, "{Message} -> {EMessage}", message, ex.Message);
                var rs = new GenericResponse()
                {
                    Code = 0,
                    Message = message
                };

                return StatusCode(500, rs);
            }

        }
    }
}
