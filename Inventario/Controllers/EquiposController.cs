using System.Linq;
using System.Net;
using Inventario.Models;
using Microsoft.AspNet.Mvc;

namespace Inventario.Controllers
{
    public class EquiposController : Controller
    {
        private InventarioContext _context;

        public EquiposController(InventarioContext context)
        {
            _context = context;
        }
        // GET: Equipos
        public ActionResult Index()
        {
            var equipos = _context.Equipo.OrderBy(t => t.SERIE).ToList();
            return View(equipos);
        }

        // // GET: Equipos/Details/5
        // public ActionResult Details(long? id)
        // {
        //     if (id == null)
        //     {
        //         return new HttpStatusCodeResult((int)HttpStatusCode.BadRequest);
        //     }
        //     Equipos equipos = db.Equipo.Find(id);
        //     if (equipos == null)
        //     {
        //         return HttpNotFound();
        //     }
        //     return View(equipos);
        // }

        // // GET: Equipos/Create
        // public ActionResult Create()
        // {
        //     return View();
        // }

        // // POST: Equipos/Create
        // // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public ActionResult Create([Bind(Include = "ID,SERIE,MODELO,TIPO_EQUIPO_ID,MARCA_EQUIPO_ID,PROCESADOR,MEMORIA,DISCO_DURO,MAC_ETH,MAC_WIFI,NO_SERIE_TECLADO,NO_SERIE_MOUSE,NO_SERIE_MONITOR,NO_SERIE_DOCK_STATION,NO_SERIE_CANDADO")] Equipos equipos)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         db.Equipo.Add(equipos);
        //         db.SaveChanges();
        //         return RedirectToAction("Index");
        //     }

        //     return View(equipos);
        // }

        // // GET: Equipos/Edit/5
        // public ActionResult Edit(long? id)
        // {
        //     if (id == null)
        //     {
        //         return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //     }
        //     Equipos equipos = db.Equipo.Find(id);
        //     if (equipos == null)
        //     {
        //         return HttpNotFound();
        //     }
        //     return View(equipos);
        // }

        // // POST: Equipos/Edit/5
        // // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public ActionResult Edit([Bind(Include = "ID,SERIE,MODELO,TIPO_EQUIPO_ID,MARCA_EQUIPO_ID,PROCESADOR,MEMORIA,DISCO_DURO,MAC_ETH,MAC_WIFI,NO_SERIE_TECLADO,NO_SERIE_MOUSE,NO_SERIE_MONITOR,NO_SERIE_DOCK_STATION,NO_SERIE_CANDADO")] Equipos equipos)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         db.Entry(equipos).State = EntityState.Modified;
        //         db.SaveChanges();
        //         return RedirectToAction("Index");
        //     }
        //     return View(equipos);
        // }

        // // GET: Equipos/Delete/5
        // public ActionResult Delete(long? id)
        // {
        //     if (id == null)
        //     {
        //         return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //     }
        //     Equipos equipos = db.Equipo.Find(id);
        //     if (equipos == null)
        //     {
        //         return HttpNotFound();
        //     }
        //     return View(equipos);
        // }

        // // POST: Equipos/Delete/5
        // [HttpPost, ActionName("Delete")]
        // [ValidateAntiForgeryToken]
        // public ActionResult DeleteConfirmed(long id)
        // {
        //     Equipos equipos = db.Equipo.Find(id);
        //     db.Equipo.Remove(equipos);
        //     db.SaveChanges();
        //     return RedirectToAction("Index");
        // }

        // protected override void Dispose(bool disposing)
        // {
        //     if (disposing)
        //     {
        //         db.Dispose();
        //     }
        //     base.Dispose(disposing);
        // }
    }
}
