using System;
using System.Web.Mvc;
using eManager.Web.Controllers;
using eManager.Web.Infrastructure;
using eManager.Web.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eManager.Test
{
    [TestClass]
    public class CreateControllerTest
    {
        [TestMethod]
        public void CreateEmployeeTest()
        {
            var controller = new EmployeeController(new DepartmentDb());
            var result = controller.Create(1) as ViewResult;
            var model = result.Model as CreateEmployeeViewModel;
            Assert.AreEqual(1,model.DepartmentId);
        }
    }
}
