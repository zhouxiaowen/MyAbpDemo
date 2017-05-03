using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProject.Web.Controllers
{
    public class SystemController : Controller
    {
        public ActionResult Users()
        {
            return View();
        }

        public ActionResult Menus()
        {
            return View();
        }

        public ActionResult Module()
        {
            return View();
        }

        public ActionResult Role()
        {
            return View();
        }
    }
}