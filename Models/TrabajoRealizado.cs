using System.ComponentModel.DataAnnotations;

namespace InventarioAVMR.Models
{
    public class TrabajoRealizado
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public double Valor {  get; set; }
        public string Foto { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public List<Item> ItemsUtilizados { get; set; } = new List<Item>();

    }
}
