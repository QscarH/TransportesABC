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
    public class PeticionController : Controller
    {
        private MyDbContext1 db = new MyDbContext1();

        // GET: Peticion
        public ActionResult Index()
        {
            return View(db.Solicitud_de_transporte.ToList());
        }

        // GET: Peticion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Solicitud_de_transporte solicitud_de_transporte = db.Solicitud_de_transporte.Find(id);
            if (solicitud_de_transporte == null)
            {
                return HttpNotFound();
            }
            return View(solicitud_de_transporte);
        }

        // GET: Peticion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Peticion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NumLote,Fecha")] Solicitud_de_transporte solicitud_de_transporte)
        {
            if (ModelState.IsValid)
            {
                db.Solicitud_de_transporte.Add(solicitud_de_transporte);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(solicitud_de_transporte);
        }

        // GET: Peticion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Solicitud_de_transporte solicitud_de_transporte = db.Solicitud_de_transporte.Find(id);
            if (solicitud_de_transporte == null)
            {
                return HttpNotFound();
            }
            return View(solicitud_de_transporte);
        }

        // POST: Peticion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NumLote,Fecha")] Solicitud_de_transporte solicitud_de_transporte)
        {
            if (ModelState.IsValid)
            {
                db.Entry(solicitud_de_transporte).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(solicitud_de_transporte);
        }

        // GET: Peticion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Solicitud_de_transporte solicitud_de_transporte = db.Solicitud_de_transporte.Find(id);
            if (solicitud_de_transporte == null)
            {
                return HttpNotFound();
            }
            return View(solicitud_de_transporte);
        }

        // POST: Peticion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Solicitud_de_transporte solicitud_de_transporte = db.Solicitud_de_transporte.Find(id);
            db.Solicitud_de_transporte.Remove(solicitud_de_transporte);
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
