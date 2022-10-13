namespace WebAPIProgII.Models
{
    public class Fecha
    {
        public Fecha()
        {
            Dia = DateTime.Now.Day;
            DiaSemana = DateTime.Now.DayOfWeek.ToString();
            Mes = DateTime.Now.Month;
            Anio = DateTime.Now.Year;
        }

        public int Dia { get; set; }
        public string DiaSemana { get; set; }
        public int Mes { get; set; }

        public int Anio { get; set; }
    }
}
