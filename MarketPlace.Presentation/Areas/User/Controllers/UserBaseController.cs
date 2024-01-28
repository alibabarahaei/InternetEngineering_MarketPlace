using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Presentation.Areas.User.Controllers
{
    public class UserBaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
