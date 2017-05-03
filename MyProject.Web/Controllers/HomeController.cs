using System.Web.Mvc;

namespace MyProject.Web.Controllers
{
    public class HomeController : MyProjectControllerBase
    {
        public ActionResult Index()
        { 
            return View(); //Layout of the angular application.
        }

        public ActionResult Home()
        {
            return View();
        }
	}
}