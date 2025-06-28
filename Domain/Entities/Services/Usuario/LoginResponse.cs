namespace Domain.Entities.Services.Usuario
{
    public class LoginResponse
    {
        public string UserName { get; set; }
        public int IdRol { get; set; }
        public int Id { get; set; }
        public long? IdLugar { get; set; }
        public string? NombreLugar { get; set; }

    }
}
