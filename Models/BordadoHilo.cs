using System.ComponentModel.DataAnnotations;

namespace InventarioAVMR.Models
{
    public class BordadoHilo
    {
        public int BordadoId { get; set; }
        public Bordado Bordado { get; set; }
        public int ColorHiloId { get; set; }
        public ColorHilo ColorHilo { get; set; }
    }
}
