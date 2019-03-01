using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication5.Models
{
    public class DB
    {
    }
    public class DataBase1 : DbContext
    {
        public DataBase1()
        { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<WebApplication5.Models.DropdownDepartment> DropdownDepartments { get; set; }
    }
}