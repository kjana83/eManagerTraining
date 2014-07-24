using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetOpenAuth;
using eManager.Domain;

namespace eManager.Web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IEmployeeDataSource db;

        public DepartmentController(IEmployeeDataSource db)
        {
            this.db = db;
        }

        public ActionResult Details(int id)
        {
            var dep = this.db.Departments.Single(p => p.Id == id);
            return View(dep);
        }

    }
}
