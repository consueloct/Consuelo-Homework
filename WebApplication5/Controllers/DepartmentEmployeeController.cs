using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;
using WebApplication5.Controllers;

namespace WebApplication5.Controllers
{
    public class DepartmentEmployeeController : Controller
    {
        private Models.DataBase1 db = new Models.DataBase1();
        // GET: DepartmentEmployee
        public ActionResult Index()
        {
            DepartmentController departmentController = new DepartmentController();
            EmployeeController empController = new EmployeeController();
            DropDownDepartmentController ddController = new DropDownDepartmentController();
            DepartmentEmployee DEview = new DepartmentEmployee();
            DEview.DEDepartmentList = departmentController.GetDepartments();
            DEview.DEEmployeeList = empController.GetEmployees();
            DEview.DepartmentListView = ddController.GetDropdownDepartments();
            return View(DEview);
        }

        public PartialViewResult GetDepartmentEmployee(string id)
        {
            if (id!=null)
            {
                IEnumerable<Employee> Employee = (from e in db.Employees
                                                  where e.DepartmentID == id
                                                  orderby e.ID
                                                  select e).ToList();
                return PartialView(Employee);
            }
            else
                return PartialView(db.Employees.ToList());
        }
    }
}