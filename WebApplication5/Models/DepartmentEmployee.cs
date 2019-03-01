using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebApplication5.Models
{
    public class DepartmentEmployee
    {
        public List<Department> DEDepartmentList { get; set; }
        public List<Employee> DEEmployeeList { get; set; }
        public string DepartmentID { get; set; }
        public IEnumerable<SelectListItem> DepartmentListView { get; set; }
    }
}