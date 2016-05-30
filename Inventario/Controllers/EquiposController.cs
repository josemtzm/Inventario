using System.Linq;
using System.Net;
using Inventario.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using Inventario.ViewModels;
using Microsoft.AspNet.Mvc.Rendering;
using System;
using System.Collections.Generic;

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
            var equipos = _context.Equipos.OrderBy(t => t.SERIE)
                .Include(x => x.MarcaEquipo)
                .Include(x => x.TipoEquipo).ToList();
            return View(equipos);
        }

        // GET: Equipos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult((int)HttpStatusCode.BadRequest);
            }
            Equipo equipos = _context.Equipos.FirstOrDefault(e => e.ID == id);
            if (equipos == null)
            {
                return HttpNotFound();
            }
            return View(equipos);
        }

        // GET: Equipos/Create
        public ActionResult Create()
        {
            var equipos = _context.Equipos.OrderBy(t => t.SERIE)
                //.Include(x => x.MarcaEquipo)
                //.Include(x => x.TipoEquipo)
                .ToList();
            // Dropdown Tipo de Equipo
            //var TipoEquipos = new List<TIPO_EQUIPO>();
            //TipoEquipos = _context.TiposEquipo.ToList();
            //ViewBag.TipoEquipos = new SelectList(TipoEquipos, "Id", "TipoEquipo");
            ////Dropdown Marca de Equipo
            //var MarcasEquipos = new List<MARCA_EQUIPO>();
            //MarcasEquipos = _context.MarcasEquipo.ToList();
            //ViewBag.MarcasEquipos = new SelectList(MarcasEquipos, "Id", "MarcaEquipo");
            return View(equipos);
        }
        
        // POST: Equipos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Equipo equipos)
        {
            if (ModelState.IsValid)
            {
                _context.Equipos.Add(equipos);
                _context.TiposEquipo.Add(equipos.TipoEquipo);
                _context.MarcasEquipo.Add(equipos.MarcaEquipo);
                _context.Teclados.Add(equipos.Teclado);
                _context.Mouses.Add(equipos.Mouse);
                _context.Monitores.Add(equipos.Monitor);
                _context.Docks.Add(equipos.DockStation);
                _context.Candados.Add(equipos.Candado);

                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(equipos);
        }

        // GET: Equipos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult((int)HttpStatusCode.BadRequest);
            }
            Equipo equipos = _context.Equipos.FirstOrDefault(e => e.ID == id);

            if (equipos == null)
            {
                return HttpNotFound();
            }
            // Dropdown Tipo de Equipo
            var TipoEquipos = new List<TIPO_EQUIPO>();
            TipoEquipos = _context.TiposEquipo.ToList();
            ViewBag.TipoEquipos = new SelectList(TipoEquipos, "Id", "TipoEquipo");
            //Dropdown Marca de Equipo
            var MarcasEquipos = new List<MARCA_EQUIPO>();
            MarcasEquipos = _context.MarcasEquipo.ToList();
            ViewBag.MarcasEquipos = new SelectList(MarcasEquipos, "Id", "MarcaEquipo");
            return View(equipos);
        }

        // POST: Equipos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind("ID,SERIE,MODELO,TipoEquipo,MarcaEquipo,PROCESADOR,MEMORIA,DISCO_DURO,MAC_ETH,MAC_WIFI,NO_SERIE_TECLADO,NO_SERIE_MOUSE,NO_SERIE_MONITOR,NO_SERIE_DOCK_STATION,NO_SERIE_CANDADO")] Equipo equipos)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(equipos).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(equipos);
        }

        // GET: Equipos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult((int)HttpStatusCode.BadRequest);
            }
            Equipo equipos = _context.Equipos.FirstOrDefault(e => e.ID == id);
            if (equipos == null)
            {
                return HttpNotFound();
            }
            return View(equipos);
        }

        // POST: Equipos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Equipo equipos = _context.Equipos.FirstOrDefault(e => e.ID == id);
            _context.Equipos.Remove(equipos);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
