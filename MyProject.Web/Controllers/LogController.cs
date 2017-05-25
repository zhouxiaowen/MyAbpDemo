using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProject.Web.Controllers
{
    public class LogController : Controller
    {
        // GET: Log
        public ActionResult LogDB()
        {
            return View();
        }
    }
}