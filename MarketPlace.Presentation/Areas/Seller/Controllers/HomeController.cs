using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Presentation.Areas.Seller.Controllers
{
    public class HomeController : SellerBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
