using System.ComponentModel.DataAnnotations;

namespace InventarioAVMR.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido  { get; set; }
        [Required]  
        public string Telefono  { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Ciudad { get; set; }

        public List<TrabajoRealizado> TrabajosRealizados { get; set; } = new List<TrabajoRealizado>();

    }
}
