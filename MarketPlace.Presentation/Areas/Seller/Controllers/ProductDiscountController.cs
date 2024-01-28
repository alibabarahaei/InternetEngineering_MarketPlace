using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Presentation.Areas.Seller.Controllers
{
    public class ProductDiscountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
