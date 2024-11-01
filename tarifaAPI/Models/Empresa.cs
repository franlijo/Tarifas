using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace tarifaAPI.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Telefono { get; set; }
        public required string Email { get; set; }
    }
}
