using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebApplication5.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string DepartmentID { get; set; }

        public IEnumerable<SelectListItem> DepartmentList { get; set; }
    }
}