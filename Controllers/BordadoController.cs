using InventarioAVMR.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventarioAVMR.Controllers
{
    public class BordadoController : Controller
    {
        private readonly AppDbContext _context;

        public BordadoController (AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BordadosRealizados()
        {
            return View();
        }

        public IActionResult CrearBordado()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> BordadosRealizadosGet()
        {
            var bordados = await _context.Bordados.ToListAsync();
            return View("BordadosRealizados", bordados);
        }
    }
}
