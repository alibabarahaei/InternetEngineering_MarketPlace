using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Presentation.Areas.User.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
