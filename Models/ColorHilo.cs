using System.ComponentModel.DataAnnotations;

namespace InventarioAVMR.Models
{
    public class ColorHilo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Foto { get; set; }
        [Required]
        public string Codigo { get; set; }

        public List<ColorHilo> ColorHilos { get; } = new List<ColorHilo>();
    }
}

