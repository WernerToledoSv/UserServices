using System.Diagnostics.CodeAnalysis;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Queries.UserEntities;
using MediatR;

namespace Application.Feature.Usuario.Commands;

public class IngresarUsuarioCommand : IRequest<ObjectResponse<UsuarioEntity>>
{
    public int IdRol { get; set; } // idrol INT

    public int IdLugar { get; set; } // idlugar INT

    [NotNull]
    public string Username { get; set; } // username VARCHAR(100) NOT NULL UNIQUE

    [NotNull]
    public string Password { get; set; } // password TEXT NOT NULL

    [NotNull]
    public string Nombres { get; set; } // nombres VARCHAR(255) NOT NULL
   
    [NotNull]
    public string Apellidos { get; set; } // apellidos VARCHAR(255) NOT NULL

    [NotNull]
    public string Sexo { get; set; } // sexo ty_sexo NOT NULL (Assuming TySexo is an enum or a defined type)

    [NotNull]
    public string Cel { get; set; } // cel VARCHAR(50) NOT NULL

    [NotNull]
    public string Email { get; set; } // email VARCHAR(255) NOT NULL UNIQUE

    [NotNull]
    public DateTime FechaIngreso { get; set; } // fechaingreso DATE NOT NULL
}
