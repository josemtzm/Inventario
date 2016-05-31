using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Inventario.Models;

namespace Inventario.Controllers
{
    public class TecladoController : Controller
    {
        private InventarioContext _context;

        public TecladoController(InventarioContext context)
        {
            _context = context;    
        }

        // GET: Teclado
        public IActionResult Index()
        {
            return View(_context.Teclados.ToList());
        }

        // GET: Teclado/Details/5
        public IActionResult Details(long? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            TECLADO tECLADO = _context.Teclados.Single(m => m.Id == id);
            if (tECLADO == null)
            {
                return HttpNotFound();
            }

            return View(tECLADO);
        }

        // GET: Teclado/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Teclado/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TECLADO tECLADO)
        {
            if (ModelState.IsValid)
            {
                _context.Teclados.Add(tECLADO);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tECLADO);
        }

        // GET: Teclado/Edit/5
        public IActionResult Edit(long? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            TECLADO tECLADO = _context.Teclados.Single(m => m.Id == id);
            if (tECLADO == null)
            {
                return HttpNotFound();
            }
            return View(tECLADO);
        }

        // POST: Teclado/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TECLADO tECLADO)
        {
            if (ModelState.IsValid)
            {
                _context.Update(tECLADO);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tECLADO);
        }

        // GET: Teclado/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(long? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            TECLADO tECLADO = _context.Teclados.Single(m => m.Id == id);
            if (tECLADO == null)
            {
                return HttpNotFound();
            }

            return View(tECLADO);
        }

        // POST: Teclado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(long id)
        {
            TECLADO tECLADO = _context.Teclados.Single(m => m.Id == id);
            _context.Teclados.Remove(tECLADO);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
