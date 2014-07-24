using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eManager.Domain;
using eManager.Web.Infrastructure;

namespace eManager.Web.Helper
{
    public class LogHandler : ActionFilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var db = new DepartmentDb();
            var actionLog = new ActionLog
            {
                Controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Action = filterContext.ActionDescriptor.ActionName + " Logged from Spl",
                DateTime = filterContext.HttpContext.Timestamp
            };
            db.AcionLogs.Add(actionLog);
            db.SaveChanges();
        }
    }
}