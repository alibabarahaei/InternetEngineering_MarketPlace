using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Presentation.Controllers
{
    public class SiteBaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
