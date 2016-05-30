using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Inventario.Models;

namespace Inventario.Controllers
{
    public class MarcaEquipoController : Controller
    {
        private InventarioContext _context;

        public MarcaEquipoController(InventarioContext context)
        {
            _context = context;    
        }

        // GET: MarcaEquipo
        public IActionResult Index()
        {
            return View(_context.MarcasEquipo.ToList());
        }

        // GET: MarcaEquipo/Details/5
        public IActionResult Details(long? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            MARCA_EQUIPO mARCA_EQUIPO = _context.MarcasEquipo.Single(m => m.Id == id);
            if (mARCA_EQUIPO == null)
            {
                return HttpNotFound();
            }

            return View(mARCA_EQUIPO);
        }

        // GET: MarcaEquipo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MarcaEquipo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MARCA_EQUIPO mARCA_EQUIPO)
        {
            if (ModelState.IsValid)
            {
                _context.MarcasEquipo.Add(mARCA_EQUIPO);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mARCA_EQUIPO);
        }

        // GET: MarcaEquipo/Edit/5
        public IActionResult Edit(long? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            MARCA_EQUIPO mARCA_EQUIPO = _context.MarcasEquipo.Single(m => m.Id == id);
            if (mARCA_EQUIPO == null)
            {
                return HttpNotFound();
            }
            return View(mARCA_EQUIPO);
        }

        // POST: MarcaEquipo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(MARCA_EQUIPO mARCA_EQUIPO)
        {
            if (ModelState.IsValid)
            {
                _context.Update(mARCA_EQUIPO);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mARCA_EQUIPO);
        }

        // GET: MarcaEquipo/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(long? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            MARCA_EQUIPO mARCA_EQUIPO = _context.MarcasEquipo.Single(m => m.Id == id);
            if (mARCA_EQUIPO == null)
            {
                return HttpNotFound();
            }

            return View(mARCA_EQUIPO);
        }

        // POST: MarcaEquipo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(long id)
        {
            MARCA_EQUIPO mARCA_EQUIPO = _context.MarcasEquipo.Single(m => m.Id == id);
            _context.MarcasEquipo.Remove(mARCA_EQUIPO);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
