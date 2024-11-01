namespace tarifaAPI.Models
{
    public class Tarifa
    {
        public int Id { get; set; }
        public DateTime DesdeFecha { get; set; }
        public DateTime HastaFecha { get; set; }
        public int DesdeTrabajadores { get; set; }
        public int HastaTrabajadores { get; set; }
        public float ImporteTrabajador { get; set; }
    }
}
