using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Presentation.Areas.User.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
