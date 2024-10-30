using System.ComponentModel.DataAnnotations;

namespace InventarioAVMR.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public int Precio { get; set; }
    }
}
