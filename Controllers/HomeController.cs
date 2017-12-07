using Microsoft.AspNetCore.Mvc;

namespace CorePlay.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
