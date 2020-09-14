using Microsoft.AspNetCore.Mvc;

namespace HRManager.Web.Controllers
{
    public class HomeController : HRManagerControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}