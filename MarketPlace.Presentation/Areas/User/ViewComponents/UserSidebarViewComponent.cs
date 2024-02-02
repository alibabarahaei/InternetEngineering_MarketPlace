using MarketPlace.Application.InterfaceServices;
using MarketPlace.Presentation.PresentationExtensions;
using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Web.Areas.User.ViewComponents
{
    public class UserSidebarViewComponent : ViewComponent
    {
        private ISellerService _sellerService;

        public UserSidebarViewComponent(ISellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.hasUserAnyActiveSellerPanel = await _sellerService.HasUserAnyActiveSellerPanel(User.GetUserId());

            return View("UserSidebar");
        }
    }
}
