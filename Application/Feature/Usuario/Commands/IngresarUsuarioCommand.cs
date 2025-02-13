using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Feature.Usuario.Commands;

public class IngresarUsuarioCommand : IRequest<ObjectResponse<UsuarioResponse>>
{
    [Required(ErrorMessage = "EL campo pIdRol es obligatorio")]
    public int pIdRol { get; set; }

    [Required(ErrorMessage = "EL campo pIdLugar es obligatorio")]
    public int pIdLugar { get; set; }

    [Required(ErrorMessage = "EL campo pIdLugar es obligatorio")]
    public string pUsername { get; set; }

    [Required(ErrorMessage = "EL campo pPassword es obligatorio")]
    public string pPassword { get; set; }

    [Required(ErrorMessage = "EL campo pNombres es obligatorio")]
    [MaxLength(255)]
    public string pNombres { get; set; }

    [Required(ErrorMessage = "EL campo pApellidos es obligatorio")]
    [MaxLength(255)]
    public string pApellidos { get; set; }

    [Required(ErrorMessage = "EL campo pSexo es obligatorio")]
    public string pSexo { get; set; }

    [Required(ErrorMessage = "EL campo pCel es obligatorio")]
    public string pCel { get; set; }

    [Required(ErrorMessage = "EL campo pEmaill es obligatorio")]
    [EmailAddress]
    public string pEmail { get; set; }
}
