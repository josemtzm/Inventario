using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Inventario.Models;

namespace Inventario.Controllers
{
    public class DockStationController : Controller
    {
        private InventarioContext _context;

        public DockStationController(InventarioContext context)
        {
            _context = context;    
        }

        // GET: DockStation
        public IActionResult Index()
        {
            return View(_context.Docks.ToList());
        }

        // GET: DockStation/Details/5
        public IActionResult Details(long? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            DOCK_STATION dOCK_STATION = _context.Docks.Single(m => m.Id == id);
            if (dOCK_STATION == null)
            {
                return HttpNotFound();
            }

            return View(dOCK_STATION);
        }

        // GET: DockStation/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DockStation/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(DOCK_STATION dOCK_STATION)
        {
            if (ModelState.IsValid)
            {
                _context.Docks.Add(dOCK_STATION);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dOCK_STATION);
        }

        // GET: DockStation/Edit/5
        public IActionResult Edit(long? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            DOCK_STATION dOCK_STATION = _context.Docks.Single(m => m.Id == id);
            if (dOCK_STATION == null)
            {
                return HttpNotFound();
            }
            return View(dOCK_STATION);
        }

        // POST: DockStation/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(DOCK_STATION dOCK_STATION)
        {
            if (ModelState.IsValid)
            {
                _context.Update(dOCK_STATION);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dOCK_STATION);
        }

        // GET: DockStation/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(long? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            DOCK_STATION dOCK_STATION = _context.Docks.Single(m => m.Id == id);
            if (dOCK_STATION == null)
            {
                return HttpNotFound();
            }

            return View(dOCK_STATION);
        }

        // POST: DockStation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(long id)
        {
            DOCK_STATION dOCK_STATION = _context.Docks.Single(m => m.Id == id);
            _context.Docks.Remove(dOCK_STATION);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
