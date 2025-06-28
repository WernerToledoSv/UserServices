namespace Domain.Entities.Services.Paciente
{
    public class PacienteResponse
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Cel { get; set; }
        public string? Direccion { get; set; }
        public int? IdLugar { get; set; }
    }
}
