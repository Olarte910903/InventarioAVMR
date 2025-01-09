using System.ComponentModel.DataAnnotations;

namespace InventarioAVMR.Models
{
    public class Bordado
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Foto { get; set; }
        [Required]
        public int CantidadColores { get; set; }

        public ICollection<BordadoHilo> BordadoHilo { get; set; } 
    }
}
