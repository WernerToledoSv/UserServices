
namespace Domain.Entities.Services.Mision
{
    public class MisionResponse
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Descripcion { get; set; }
        public string Mision { get; set; }
        public string Vision { get; set; }
        public string Estado { get; set; }
    }
}
