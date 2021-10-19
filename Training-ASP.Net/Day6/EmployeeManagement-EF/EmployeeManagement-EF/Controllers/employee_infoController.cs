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
    public class employee_infoController : Controller
    {
        private Employee_DBEntities1 db = new Employee_DBEntities1();

        // GET: employee_info
        public ActionResult Index()
        {
            var employee_info = db.employee_info.Include(e => e.dept_info);
            return View(employee_info.ToList());
        }

        // GET: employee_info/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            employee_info employee_info = db.employee_info.Find(id);
            if (employee_info == null)
            {
                return HttpNotFound();
            }
            return View(employee_info);
        }

        // GET: employee_info/Create
        public ActionResult Create()
        {
            ViewBag.e_Dept = new SelectList(db.dept_info, "d_No", "d_Name");
            return View();
        }

        // POST: employee_info/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "e_No,e_Name,e_Designation,e_Salary,e_Dept")] employee_info employee_info)
        {
            if (ModelState.IsValid)
            {
                db.employee_info.Add(employee_info);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.e_Dept = new SelectList(db.dept_info, "d_No", "d_Name", employee_info.e_Dept);
            return View(employee_info);
        }

        // GET: employee_info/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            employee_info employee_info = db.employee_info.Find(id);
            if (employee_info == null)
            {
                return HttpNotFound();
            }
            ViewBag.e_Dept = new SelectList(db.dept_info, "d_No", "d_Name", employee_info.e_Dept);
            return View(employee_info);
        }

        // POST: employee_info/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "e_No,e_Name,e_Designation,e_Salary,e_Dept")] employee_info employee_info)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee_info).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.e_Dept = new SelectList(db.dept_info, "d_No", "d_Name", employee_info.e_Dept);
            return View(employee_info);
        }

        // GET: employee_info/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            employee_info employee_info = db.employee_info.Find(id);
            if (employee_info == null)
            {
                return HttpNotFound();
            }
            return View(employee_info);
        }

        // POST: employee_info/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            employee_info employee_info = db.employee_info.Find(id);
            db.employee_info.Remove(employee_info);
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
