
namespace Domain.Entities.Services.Lugar
{
    public class LugarResponse
    {
        public int Id { get; set; } 
        public string Nombre { get; set; } 
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; } 
        public DateTime Fecha { get; set; } 
        public string Estado { get; set; }
    }
}
