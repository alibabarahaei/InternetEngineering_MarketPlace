using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Presentation.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
