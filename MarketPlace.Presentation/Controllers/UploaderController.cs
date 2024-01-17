using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Presentation.Controllers
{
    public class UploaderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
