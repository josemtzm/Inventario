using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Inventario.Models;

namespace Inventario.Controllers
{
    public class MonitorController : Controller
    {
        private InventarioContext _context;

        public MonitorController(InventarioContext context)
        {
            _context = context;    
        }

        // GET: Monitor
        public IActionResult Index()
        {
            return View(_context.Monitores.ToList());
        }

        // GET: Monitor/Details/5
        public IActionResult Details(long? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            MONITOR mONITOR = _context.Monitores.Single(m => m.Id == id);
            if (mONITOR == null)
            {
                return HttpNotFound();
            }

            return View(mONITOR);
        }

        // GET: Monitor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Monitor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MONITOR mONITOR)
        {
            if (ModelState.IsValid)
            {
                _context.Monitores.Add(mONITOR);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mONITOR);
        }

        // GET: Monitor/Edit/5
        public IActionResult Edit(long? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            MONITOR mONITOR = _context.Monitores.Single(m => m.Id == id);
            if (mONITOR == null)
            {
                return HttpNotFound();
            }
            return View(mONITOR);
        }

        // POST: Monitor/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(MONITOR mONITOR)
        {
            if (ModelState.IsValid)
            {
                _context.Update(mONITOR);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mONITOR);
        }

        // GET: Monitor/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(long? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            MONITOR mONITOR = _context.Monitores.Single(m => m.Id == id);
            if (mONITOR == null)
            {
                return HttpNotFound();
            }

            return View(mONITOR);
        }

        // POST: Monitor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(long id)
        {
            MONITOR mONITOR = _context.Monitores.Single(m => m.Id == id);
            _context.Monitores.Remove(mONITOR);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
