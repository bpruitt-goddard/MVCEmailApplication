using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCEmailApplication.Models;

namespace MVCEmailApplication.Controllers
{
    public class SystemEmailController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SystemEmails
        public ActionResult Index()
        {
            return View(db.SystemEmails.ToList());
        }

        // GET: SystemEmails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemEmail systemEmail = db.SystemEmails.Find(id);
            if (systemEmail == null)
            {
                return HttpNotFound();
            }
            return View(systemEmail);
        }

        // GET: SystemEmails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SystemEmails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,UserId,Subject,DeliveryDate,OpenedDate")] SystemEmail systemEmail)
        {
            if (ModelState.IsValid)
            {
                db.SystemEmails.Add(systemEmail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(systemEmail);
        }

        // GET: SystemEmails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemEmail systemEmail = db.SystemEmails.Find(id);
            if (systemEmail == null)
            {
                return HttpNotFound();
            }
            return View(systemEmail);
        }

        // POST: SystemEmails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,UserId,Subject,DeliveryDate,OpenedDate")] SystemEmail systemEmail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(systemEmail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(systemEmail);
        }

        // GET: SystemEmails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemEmail systemEmail = db.SystemEmails.Find(id);
            if (systemEmail == null)
            {
                return HttpNotFound();
            }
            return View(systemEmail);
        }

        // POST: SystemEmails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SystemEmail systemEmail = db.SystemEmails.Find(id);
            db.SystemEmails.Remove(systemEmail);
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
