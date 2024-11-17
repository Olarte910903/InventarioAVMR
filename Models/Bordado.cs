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
        public string Descripcion {  get; set; }
        [Required]
        public int IdColores { get; set; }

        public List<BordadoHilo> BordadoHilo { get; } = new List<BordadoHilo>();
    }
}
