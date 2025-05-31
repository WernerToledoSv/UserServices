namespace Domain.Entities.Services.Usuario;

public class UsuarioResponse
{
    public long Id { get; set; }
    public long IdRol { get; set; }
    public long IdLugar { get; set; }
    public string Rol { get; set; }
    public string Lugar { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public string Sexo { get; set; }
    public string Cel { get; set; }  
    public string Email { get; set; }
    public DateTime FechaIngreso { get; set; }
    public string Estado { get; set; }
}
