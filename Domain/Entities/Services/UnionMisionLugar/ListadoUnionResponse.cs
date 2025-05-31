namespace Domain.Entities.Services.UnionMisionLugar
{
    public class ListadoUnionResponse
    {
        public int Id { get; set; }
        public string Mision { get; set; }
        public DateTime FechaInicioMision { get; set; }
        public DateTime FechaFinMision { get; set; }
        public DateTime FechaLugar { get; set; }
        public string Descripcion { get; set; } 
        public string Lugar { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
    }
}
