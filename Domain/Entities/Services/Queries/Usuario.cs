
namespace Domain.Entities.Services.Queries
{
    public class Usuario
    {

        public int Id { get; set; } // id SERIAL PRIMARY KEY
        public int IdRol { get; set; } // idrol INT
        public int IdLugar { get; set; } // idlugar INT
        public string Username { get; set; } // username VARCHAR(100) NOT NULL UNIQUE
        public string Password { get; set; } // password TEXT NOT NULL
        public string Nombres { get; set; } // nombres VARCHAR(255) NOT NULL
        public string Apellidos { get; set; } // apellidos VARCHAR(255) NOT NULL
        public string Sexo  { get; set; } // sexo ty_sexo NOT NULL
        public string Cel { get; set; } // cel VARCHAR(50) NOT NULL
        public string Email { get; set; } // email VARCHAR(255) NOT NULL UNIQUE
        public DateTime FechaIngreso { get; set; } // fechaingreso DATE NOT NULL
        public string Estado { get; set; }  // estado est_users DEFAULT 'disponible'
    }
}
