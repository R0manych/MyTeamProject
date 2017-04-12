using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class MyController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "My controller method";
            return View("Index");
        }
    }
}