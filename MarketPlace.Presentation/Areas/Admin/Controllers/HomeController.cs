using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Presentation.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        #region index

        public IActionResult Index()
        {
            return View();
        }

        #endregion
    }
}
