using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;
namespace WebApplication5.Controllers
{
    public class DropDownDepartmentController : Controller
    {
        // GET: DropDownDepartment
        private Models.DataBase1 db = new Models.DataBase1();
        public ActionResult Index()
        {
            DropdownDepartment dropdownDepartment = new DropdownDepartment();
            dropdownDepartment.DropdownDepartmentList = (from p in db.Departments
                                                         select new SelectListItem { Text = p.Name, Value = p.ID.ToString() }
                                                            );
            return View(dropdownDepartment);
            //return View(GetDropdownDepartments());
        }
        public IEnumerable<SelectListItem> GetDropdownDepartments()
        {
            DropdownDepartment dropdownDepartment = new DropdownDepartment();
            dropdownDepartment.DropdownDepartmentList = (from p in db.Departments
                                                         select new SelectListItem { Text = p.Name, Value = p.ID.ToString() }
                                                            );
            return dropdownDepartment.DropdownDepartmentList;
        }
    }
}