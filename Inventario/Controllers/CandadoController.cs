using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Inventario.Models;

namespace Inventario.Controllers
{
    public class CandadoController : Controller
    {
        private InventarioContext _context;

        public CandadoController(InventarioContext context)
        {
            _context = context;    
        }

        // GET: Candado
        public IActionResult Index()
        {
            return View(_context.Candados.ToList());
        }

        // GET: Candado/Details/5
        public IActionResult Details(long? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            CANDADO cANDADO = _context.Candados.Single(m => m.Id == id);
            if (cANDADO == null)
            {
                return HttpNotFound();
            }

            return View(cANDADO);
        }

        // GET: Candado/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Candado/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CANDADO cANDADO)
        {
            if (ModelState.IsValid)
            {
                _context.Candados.Add(cANDADO);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cANDADO);
        }

        // GET: Candado/Edit/5
        public IActionResult Edit(long? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            CANDADO cANDADO = _context.Candados.Single(m => m.Id == id);
            if (cANDADO == null)
            {
                return HttpNotFound();
            }
            return View(cANDADO);
        }

        // POST: Candado/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CANDADO cANDADO)
        {
            if (ModelState.IsValid)
            {
                _context.Update(cANDADO);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cANDADO);
        }

        // GET: Candado/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(long? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            CANDADO cANDADO = _context.Candados.Single(m => m.Id == id);
            if (cANDADO == null)
            {
                return HttpNotFound();
            }

            return View(cANDADO);
        }

        // POST: Candado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(long id)
        {
            CANDADO cANDADO = _context.Candados.Single(m => m.Id == id);
            _context.Candados.Remove(cANDADO);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
