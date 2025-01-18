using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Queries.UserEntities;
using MediatR;

namespace Application.Feature.Usuario.Commands;

public class IngresarUsuarioCommand : IRequest<ObjectResponse<UsuarioEntity>>
{
    [Required]
    public int pIdRol { get; set; } // idrol INT

    [Required]
    public int pIdLugar { get; set; } // idlugar INT

    [Required]
    public string pUsername { get; set; } // username VARCHAR(100) NOT NULL UNIQUE

    [Required]
    public string pPassword { get; set; } // password TEXT NOT NULL

    [Required]
    [MaxLength(255)]
    public string pNombres { get; set; } // nombres VARCHAR(255) NOT NULL

    [Required]
    [MaxLength(255)]
    public string pApellidos { get; set; } // apellidos VARCHAR(255) NOT NULL

    [Required]
    public string pSexo { get; set; } // sexo ty_sexo NOT NULL (Assuming TySexo is an enum or a defined type)

    [Required]
    public string pCel { get; set; } // cel VARCHAR(50) NOT NULL

    [Required]
    [EmailAddress]
    public string pEmail { get; set; } // email VARCHAR(255) NOT NULL UNIQUE
}
