using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Inventario.Models;

namespace Inventario.Controllers
{
    public class MouseController : Controller
    {
        private InventarioContext _context;

        public MouseController(InventarioContext context)
        {
            _context = context;    
        }

        // GET: Mouse
        public IActionResult Index()
        {
            return View(_context.Mouses.ToList());
        }

        // GET: Mouse/Details/5
        public IActionResult Details(long? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            MOUSE mOUSE = _context.Mouses.Single(m => m.Id == id);
            if (mOUSE == null)
            {
                return HttpNotFound();
            }

            return View(mOUSE);
        }

        // GET: Mouse/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mouse/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MOUSE mOUSE)
        {
            if (ModelState.IsValid)
            {
                _context.Mouses.Add(mOUSE);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mOUSE);
        }

        // GET: Mouse/Edit/5
        public IActionResult Edit(long? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            MOUSE mOUSE = _context.Mouses.Single(m => m.Id == id);
            if (mOUSE == null)
            {
                return HttpNotFound();
            }
            return View(mOUSE);
        }

        // POST: Mouse/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(MOUSE mOUSE)
        {
            if (ModelState.IsValid)
            {
                _context.Update(mOUSE);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mOUSE);
        }

        // GET: Mouse/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(long? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            MOUSE mOUSE = _context.Mouses.Single(m => m.Id == id);
            if (mOUSE == null)
            {
                return HttpNotFound();
            }

            return View(mOUSE);
        }

        // POST: Mouse/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(long id)
        {
            MOUSE mOUSE = _context.Mouses.Single(m => m.Id == id);
            _context.Mouses.Remove(mOUSE);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
