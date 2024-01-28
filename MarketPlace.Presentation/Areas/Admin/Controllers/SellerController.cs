using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Presentation.Areas.Admin.Controllers
{
    public class SellerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
