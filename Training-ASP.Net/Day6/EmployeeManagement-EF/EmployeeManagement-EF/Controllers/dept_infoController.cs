using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmployeeManagement_EF.Models;

namespace EmployeeManagement_EF.Controllers
{
    public class dept_infoController : Controller
    {
        private Employee_DBEntities1 db = new Employee_DBEntities1();

        // GET: dept_info
        public ActionResult Index()
        {
            var dept_info = db.dept_info.Include(d => d.deptname_info);
            return View(dept_info.ToList());
        }

        // GET: dept_info/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dept_info dept_info = db.dept_info.Find(id);
            if (dept_info == null)
            {
                return HttpNotFound();
            }
            return View(dept_info);
        }

        // GET: dept_info/Create
        public ActionResult Create()
        {
            ViewBag.d_Name = new SelectList(db.deptname_info, "Department", "Department");
            return View();
        }

        // POST: dept_info/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "d_No,d_Name,d_Location")] dept_info dept_info)
        {
            if (ModelState.IsValid)
            {
                db.dept_info.Add(dept_info);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.d_Name = new SelectList(db.deptname_info, "Department", "Department", dept_info.d_Name);
            return View(dept_info);
        }

        // GET: dept_info/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dept_info dept_info = db.dept_info.Find(id);
            if (dept_info == null)
            {
                return HttpNotFound();
            }
            ViewBag.d_Name = new SelectList(db.deptname_info, "Department", "Department", dept_info.d_Name);
            return View(dept_info);
        }

        // POST: dept_info/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "d_No,d_Name,d_Location")] dept_info dept_info)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dept_info).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.d_Name = new SelectList(db.deptname_info, "Department", "Department", dept_info.d_Name);
            return View(dept_info);
        }

        // GET: dept_info/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dept_info dept_info = db.dept_info.Find(id);
            if (dept_info == null)
            {
                return HttpNotFound();
            }
            return View(dept_info);
        }

        // POST: dept_info/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            dept_info dept_info = db.dept_info.Find(id);
            db.dept_info.Remove(dept_info);
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
