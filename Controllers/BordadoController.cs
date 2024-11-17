using InventarioAVMR.Data;
using InventarioAVMR.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventarioAVMR.Controllers
{
    public class BordadoController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BordadoController (AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
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

        public IActionResult CrearBordadoBd(Bordado bordado)
        {
            return RedirectToAction("CrearBordado");
        }

        [HttpGet]
        public async Task<IActionResult> BordadosRealizadosGet()
        {
            var bordados = await _context.Bordados.ToListAsync();
            return View("BordadosRealizados", bordados);
        }

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile image, Bordado bordado)
        {
            if(image == null || image.Length == 0)
            {
                return BadRequest("Por favor selecciona un archivo");
            }

            //Crear la ruta para guardar la imagen
            string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Imagenes/Bordado");
            //Directory.CreateDirectory(uploadsFolder);

            string uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            //Guardar la imagen
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await image.CopyToAsync(fileStream);
            }

            //Guardar los datos en la BD
            var bordado1 = bordado;
            bordado1.Nombre = bordado.Nombre;
            bordado1.Descripcion = bordado.Descripcion;
            //Ruta relativa
            string relativePath = Path.Combine("/Imagenes/Bordado", uniqueFileName).Replace("\\", "/");
            bordado1.Foto = relativePath;
            bordado1.IdColores = bordado.IdColores;

            await _context.AddAsync(bordado1);
            await _context.SaveChangesAsync();


            return RedirectToAction("Index");
        }
    }
}
