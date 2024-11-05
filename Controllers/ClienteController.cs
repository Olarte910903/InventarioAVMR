using Microsoft.AspNetCore.Mvc;

namespace InventarioAVMR.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
