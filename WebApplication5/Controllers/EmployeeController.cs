using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;
using WebApplication5.Controllers;

namespace WebApplication5.Controllers
{
    public class EmployeeController : Controller
    {
        //public object EmployeeList { get; private set; }
        //public object DepartmentList { get; private set; }
        
        private Models.DataBase1 db = new Models.DataBase1();

        // GET: Employee
        public ActionResult Index()
        {
            var Employee = from e in db.Employees
                           orderby e.ID
                            select e;
            
            return View(Employee);
        }
        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            var employee = db.Employees.Single(m => m.ID == id);
            employee.DepartmentList = GetDepartment();
            return View(employee);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            Employee e = new Employee();
            e.DepartmentList = GetDepartment();
            return View(e);
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Models.Employee emp)
        {
            try
            {
                db.Employees.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            var employee = db.Employees.Single(m => m.ID == id);
            employee.DepartmentList = GetDepartment();
            return View(employee);
        }
        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var employee = db.Employees.Single(m => m.ID == id);
                if (TryUpdateModel(employee))
                {
                    //To Do:- database code
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(employee);
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            var employee = db.Employees.Single(m => m.ID == id);
            employee.DepartmentList = GetDepartment();
            return View(employee);
        }
        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var employee = db.Employees.Single(m => m.ID == id);
            try
            {
                db.Employees.Remove(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public IEnumerable<SelectListItem> GetDepartment()
        {
            DropDownDepartmentController dp = new DropDownDepartmentController();
            return dp.GetDropdownDepartments();
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> emp = (from e in db.Employees
                                           orderby e.ID
                                           select e).ToList();
            return emp;
        }
        public string MsgEmployee()
        {
            string res = "Hello Ajax";
            return res;
        }
    }

}
