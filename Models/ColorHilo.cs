using System.ComponentModel.DataAnnotations;

namespace InventarioAVMR.Models
{
    public class ColorHilo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        [Required]
        public string Marca { get; set; }

        //public List<ColorHilo> ColorHilos { get; } = new List<ColorHilo>();
        public ICollection<BordadoHilo> BordadoHilo { get; set; }
    }
}

