using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using DotNetOpenAuth;
using eManager.Domain;
using eManager.Web.Helper;
using eManager.Web.Models;

namespace eManager.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeDataSource db;

        public EmployeeController(IEmployeeDataSource db)
        {
            this.db = db;
        }

        [HttpGet]
        public ActionResult Create(int departmentId)
        {
            var viewModel = new CreateEmployeeViewModel
            {
                DepartmentId = departmentId
            };
            return View(viewModel);
        }

        [HttpPost]
        [LogHandler]
        public ActionResult Create(CreateEmployeeViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var department = this.db.Departments.Single(d => d.Id == viewModel.DepartmentId);
                var emp = new Employee
                {
                    Name = viewModel.Name,
                    HireDate = viewModel.JoiningDate
                };
                department.Employees.Add(emp);
                this.db.Save();
                return RedirectToAction("Details", "Department", new { id = viewModel.DepartmentId });
            }
            return View(viewModel);
        }

    }
}
