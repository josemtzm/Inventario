using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Inventario.Models;

namespace Inventario.Controllers
{
    public class TipoEquipoController : Controller
    {
        private InventarioContext _context;

        public TipoEquipoController(InventarioContext context)
        {
            _context = context;    
        }

        // GET: TIPO_EQUIPO
        public IActionResult Index()
        {
            return View(_context.TiposEquipo.ToList());
        }

        // GET: TIPO_EQUIPO/Details/5
        public IActionResult Details(long? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            TIPO_EQUIPO tIPO_EQUIPO = _context.TiposEquipo.Single(m => m.Id == id);
            if (tIPO_EQUIPO == null)
            {
                return HttpNotFound();
            }

            return View(tIPO_EQUIPO);
        }

        // GET: TIPO_EQUIPO/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TIPO_EQUIPO/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TIPO_EQUIPO tIPO_EQUIPO)
        {
            if (ModelState.IsValid)
            {
                _context.TiposEquipo.Add(tIPO_EQUIPO);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tIPO_EQUIPO);
        }

        // GET: TIPO_EQUIPO/Edit/5
        public IActionResult Edit(long? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            TIPO_EQUIPO tIPO_EQUIPO = _context.TiposEquipo.Single(m => m.Id == id);
            if (tIPO_EQUIPO == null)
            {
                return HttpNotFound();
            }
            return View(tIPO_EQUIPO);
        }

        // POST: TIPO_EQUIPO/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TIPO_EQUIPO tIPO_EQUIPO)
        {
            if (ModelState.IsValid)
            {
                _context.Update(tIPO_EQUIPO);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tIPO_EQUIPO);
        }

        // GET: TIPO_EQUIPO/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(long? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            TIPO_EQUIPO tIPO_EQUIPO = _context.TiposEquipo.Single(m => m.Id == id);
            if (tIPO_EQUIPO == null)
            {
                return HttpNotFound();
            }

            return View(tIPO_EQUIPO);
        }

        // POST: TIPO_EQUIPO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(long id)
        {
            TIPO_EQUIPO tIPO_EQUIPO = _context.TiposEquipo.Single(m => m.Id == id);
            _context.TiposEquipo.Remove(tIPO_EQUIPO);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
