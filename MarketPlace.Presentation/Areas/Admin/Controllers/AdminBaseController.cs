using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Presentation.Areas.Admin.Controllers
{
    public class AdminBaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
