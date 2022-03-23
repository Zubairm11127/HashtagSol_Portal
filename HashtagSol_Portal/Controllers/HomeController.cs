using HashtagSol_Portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HashtagSol_Portal.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AjaxPostCall(EmailSettings emailDatat)
        {
            //Employee employee = new Employee
            //{
            //    Name = employeeData.Name,
            //    Designation = employeeData.Designation,
            //    Location = employeeData.Location
            //};
            return Json(emailDatat, JsonRequestBehavior.AllowGet);
        }
    }
}