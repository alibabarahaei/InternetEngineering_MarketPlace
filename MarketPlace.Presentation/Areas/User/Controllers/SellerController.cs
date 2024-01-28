using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Presentation.Areas.User.Controllers
{
    public class SellerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
