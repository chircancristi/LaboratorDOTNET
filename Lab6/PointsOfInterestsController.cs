using System.Web;
using System.Web.Mvc;


namespace lab6
{
    public class HelloWorldController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(PointOfInterest point)
        {
            ViewBag.Message = point.name;
            ViewBag.Message = point.description;

            return View();
        }
    }
}