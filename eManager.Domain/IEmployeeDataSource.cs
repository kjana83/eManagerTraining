using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eManager.Domain
{
    public interface IEmployeeDataSource
    {
        IQueryable<Department> Departments { get; }  
        IQueryable<Employee> Employees { get; }
        void Save();
    }
}
