using InventarioAVMR.Data;
using InventarioAVMR.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventarioAVMR.Controllers
{
    public class ItemController : Controller
    {
        private readonly AppDbContext _context;

        public ItemController(AppDbContext context)
        {
            _context = context;
        }
        // GET: ItemController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        //public async Task<ActionResult> GetElements()
        //{
        //    var items = await _context.Items.ToListAsync();
        //    return View("Index", items);
        //}

        public async Task<ActionResult> GetElements(int pageIndex = 1, int pageSize = 5)
        {
            var items = _context.Items.AsQueryable();
            var paginatedList = await Paginacion<Item>.CreateAsync(items, pageIndex, pageSize);
            return View("Index", paginatedList);
        }

        // GET: ItemController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ItemController/Create
        public ActionResult CreateItem()
        {
            return View();
        }

        // POST: ItemController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Item item)
        {
            var itemData = item;
            itemData.Nombre = item.Nombre;
            itemData.Cantidad = item.Cantidad;
            itemData.Precio = item.Precio;  
            await _context.Items.AddAsync(itemData);
            await _context.SaveChangesAsync();
            return RedirectToAction("GetElements");
        }

        // Modificar Item
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult<Item>> Edit(int id, Item item)
        {
            var itemEdit = await _context.Items.FindAsync(id);

            if (itemEdit == null)
            {
                return NotFound();
            }

            itemEdit.Nombre = item.Nombre;
            itemEdit.Cantidad = item.Cantidad;
            itemEdit.Precio = item.Precio;
            _context.Update(itemEdit);
            await _context.SaveChangesAsync();

            return RedirectToAction("GetElements");
        }

        // POST: ItemController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id)
        {
            var item = _context.Items.Find(id);
            _context.Items.Remove(item);
            await _context.SaveChangesAsync();


            return RedirectToAction("GetElements");
        }
    }
}
