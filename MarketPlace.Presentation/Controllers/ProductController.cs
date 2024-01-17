using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Presentation.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
