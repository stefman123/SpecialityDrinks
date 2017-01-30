using System.Web.Mvc;

namespace SpecialityDrinks.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Basic CRUD application to view Products.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "StefanGayle@hotmail.co.uk";

            return View();
        }
    }
}