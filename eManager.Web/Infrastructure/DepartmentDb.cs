using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using eManager.Domain;

namespace eManager.Web.Infrastructure
{
    public class DepartmentDb : DbContext, IEmployeeDataSource
    {
        public DbSet<Employee> Employees { get; set; } 
        public DbSet<Department> Departments { get; set; }
        public DbSet<ActionLog> AcionLogs { get; set; }

        IQueryable<Department> IEmployeeDataSource.Departments
        {
            get { return Departments; }
        }

        IQueryable<Employee> IEmployeeDataSource.Employees
        {
            get { return Employees; }
        }

        void IEmployeeDataSource.Save()
        {
            SaveChanges();
        }
    }
}