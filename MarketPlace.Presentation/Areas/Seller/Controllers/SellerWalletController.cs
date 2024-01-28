using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Presentation.Areas.Seller.Controllers
{
    public class SellerWalletController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
