using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class DepartmentController : System.Web.Mvc.Controller
    {
        public object DepList { get; private set; }
        private Models.DataBase1 db = new Models.DataBase1();
        // GET: Department
        public ActionResult Index()
        {
            var department = from e in db.Departments
                           orderby e.ID
                           select e;
            return View(department);
        }

        // GET: Department/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Department/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Department/Create
        [HttpPost]
        public ActionResult Create(Models.Department dep)
        {
            try
            {
                db.Departments.Add(dep);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Department/Edit/5
        public ActionResult Edit(int id)
        {
            var dep = db.Departments.Single(m => m.ID == id);
            return View(dep);
        }

        // POST: Department/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var dep = db.Departments.Single(m => m.ID == id);
                if (TryUpdateModel(dep))
                {
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(dep);
            }
            catch
            {
                return View();
            }
        }

        // GET: Department/Delete/5
        public ActionResult Delete(int id)
        {
            var dep = db.Departments.Single(m => m.ID == id);
            return View(dep);
        }

        // POST: Department/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var dep = db.Departments.Single(m => m.ID == id);
            try
            {
                db.Departments.Remove(dep);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public List<Department> GetDepartments()
        {
            List<Department> department = (from e in db.Departments
                             orderby e.ID
                             select e).ToList();
            return department;
        }
    }
}
