namespace Domain.Entities.UserEntities;

public class UsuarioEntity
{
    public int Id { get; set; } // SERIAL PRIMARY KEY

    public int IdRol { get; set; } // idrol INT

    public int IdLugar { get; set; } // idlugar INT

    public string Username { get; set; } = string.Empty; // username VARCHAR(100) NOT NULL UNIQUE

    public string Password { get; set; } = string.Empty; // password TEXT NOT NULL

    public string Nombres { get; set; } = string.Empty; // nombres VARCHAR(255) NOT NULL

    public string Apellidos { get; set; } = string.Empty; // apellidos VARCHAR(255) NOT NULL

    public string Sexo { get; set; } // sexo ty_sexo NOT NULL (Assuming TySexo is an enum or a defined type)

    public string Cel { get; set; } = string.Empty; // cel VARCHAR(50) NOT NULL

    public string Email { get; set; } = string.Empty; // email VARCHAR(255) NOT NULL UNIQUE

    public DateTime FechaIngreso { get; set; } // fechaingreso DATE NOT NULL

    public string Estado { get; set; }
}
