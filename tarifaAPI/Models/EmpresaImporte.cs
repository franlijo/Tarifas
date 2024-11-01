namespace tarifaAPI.Models
{
    public class EmpresaImporte
    {
        public int Id { get; set; }
        public int IdEmpresa {get; set; }
        public DateTime Fecha { get; set; }
        public float Importe { get; set; }
    }
}
