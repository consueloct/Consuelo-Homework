using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebApplication5.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }

        //public IEnumerable<SelectListItem> DepartmentEmployeeList { get; set; }
    }
}