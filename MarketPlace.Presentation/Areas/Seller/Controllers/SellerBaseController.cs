using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Presentation.Areas.Seller.Controllers
{
    public class SellerBaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
