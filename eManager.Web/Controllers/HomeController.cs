using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetOpenAuth;
using eManager.Domain;

namespace eManager.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeDataSource db;

        public HomeController(IEmployeeDataSource db)
        {
            this.db = db;
        }

        public ActionResult Index()
        {
            var departments = this.db.Departments;
            return View(departments);
        }

    }
}
