using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebApplication5.Models
{
    public class DropdownDepartment
    {
        public DropdownDepartment()
        {
            DropdownDepartmentList = new List<SelectListItem>();
        }        
        [Key]
        public int DepartmentID { get; set; }        
        public IEnumerable<SelectListItem> DropdownDepartmentList { get; set; }
    }
}