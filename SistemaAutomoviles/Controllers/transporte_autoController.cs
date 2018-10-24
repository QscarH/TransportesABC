using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SistemaAutomoviles.Models;

namespace SistemaAutomoviles.Controllers
{
    public class transporte_autoController : Controller
    {
        private MyDbContext1 db = new MyDbContext1();

        // GET: transporte_auto
        public ActionResult Index()
        {
            var transporte_auto = db.transporte_auto.Include(t => t.Automovil).Include(t => t.Solicitud_de_transporte);
            return View(transporte_auto.ToList());
        }

        // GET: transporte_auto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            transporte_auto transporte_auto = db.transporte_auto.Find(id);
            if (transporte_auto == null)
            {
                return HttpNotFound();
            }
            return View(transporte_auto);
        }

        // GET: transporte_auto/Create
        public ActionResult Create()
        {
            ViewBag.FolioAuto = new SelectList(db.Automovil, "FolioAuto", "FolioAuto");
            ViewBag.NumLote = new SelectList(db.Solicitud_de_transporte, "NumLote", "NumLote");
            return View();
        }

        // POST: transporte_auto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NumLote,FolioAuto,id")] transporte_auto transporte_auto)
        {
            if (ModelState.IsValid)
            {
                db.transporte_auto.Add(transporte_auto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FolioAuto = new SelectList(db.Automovil, "FolioAuto", "FolioAuto", transporte_auto.FolioAuto);
            ViewBag.FolioAuto = new SelectList(db.Automovil, "FolioAuto", "Marca", transporte_auto.FolioAuto);
            ViewBag.NumLote = new SelectList(db.Solicitud_de_transporte, "NumLote", "NumLote", transporte_auto.NumLote);
            return View(transporte_auto);
        }

        // GET: transporte_auto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            transporte_auto transporte_auto = db.transporte_auto.Find(id);
            if (transporte_auto == null)
            {
                return HttpNotFound();
            }
            ViewBag.FolioAuto = new SelectList(db.Automovil, "FolioAuto", "FolioAuto", transporte_auto.FolioAuto);
            ViewBag.FolioAuto = new SelectList(db.Automovil, "FolioAuto", "Marca", transporte_auto.FolioAuto);
            ViewBag.NumLote = new SelectList(db.Solicitud_de_transporte, "Número de Lote", "Número de Lote", transporte_auto.NumLote);
            return View(transporte_auto);
        }

        // POST: transporte_auto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NumLote,FolioAuto,id")] transporte_auto transporte_auto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(transporte_auto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FolioAuto = new SelectList(db.Automovil, "FolioAuto", "Marca", transporte_auto.FolioAuto);
            ViewBag.NumLote = new SelectList(db.Solicitud_de_transporte, "NumLote", "NumLote", transporte_auto.NumLote);
            return View(transporte_auto);
        }

        // GET: transporte_auto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            transporte_auto transporte_auto = db.transporte_auto.Find(id);
            if (transporte_auto == null)
            {
                return HttpNotFound();
            }
            return View(transporte_auto);
        }

        // POST: transporte_auto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            transporte_auto transporte_auto = db.transporte_auto.Find(id);
            db.transporte_auto.Remove(transporte_auto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
