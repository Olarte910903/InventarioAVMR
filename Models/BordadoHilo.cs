using System.ComponentModel.DataAnnotations;

namespace InventarioAVMR.Models
{
    public class BordadoHilo
    {
        [Key]
        public int Id { get; set; }
        [Required] 
        public int IdBordado { get; set; }
        [Required]
        public int IdHilo   { get; set; }

        public int BordadoId { get; set; } //Foreign Key
        public int ColorHiloId { get; set; } // Foreign Key
        public Bordado Bordado { get; set; } = null!;
        public ColorHilo ColorHilo { get; set; } = null!;
    }
}
