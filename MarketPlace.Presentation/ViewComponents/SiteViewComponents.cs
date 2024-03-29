﻿using MarketPlace.Application.InterfaceServices;
using MarketPlace.Domain.Models.Site;
using MarketPlace.Presentation.PresentationExtensions;
using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Web.ViewComponents
{
    #region site header

    public class SiteHeaderViewComponent : ViewComponent
    {
        private readonly ISiteService _siteService;
        private readonly IUserService _userService;
        private readonly IProductService _productService;

        public SiteHeaderViewComponent(ISiteService siteService, IUserService userService, IProductService productService)
        {
            _siteService = siteService;
            _userService = userService;
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.siteSetting = await _siteService.GetDefaultSiteSetting();
            if (ViewBag.siteSetting == null)
            {
                ViewBag.siteSetting = new SiteSetting()
                {
                    Mobile = "09330807786",
                    IsDefault = true,
                    Phone = "09330807786",
                    AboutUs = "فروشگاه",
                    Address = "دانشگاه شاهد",
                    Email = "alibabarahaei@gmail.com",
                    
                };
            }
            ViewBag.user = await _userService.GetUserByMobile(User.Identity.Name);
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.user = await _userService.GetUserByMobile(User.Identity.Name);
            }

            ViewBag.ProductCategories = await _productService.GetAllActiveProductCategories();

            return View("SiteHeader");
        }
    }

    #endregion

    #region site footer

    public class SiteFooterViewComponent : ViewComponent
    {
        private readonly ISiteService _siteService;

        public SiteFooterViewComponent(ISiteService siteService)
        {
            _siteService = siteService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            ViewBag.siteSetting = await _siteService.GetDefaultSiteSetting();
            if (ViewBag.siteSetting == null)
            {
                ViewBag.siteSetting = new SiteSetting()
                {
                    Mobile = "09330807786",
                    IsDefault = true,
                    Phone = "09330807786",
                    AboutUs = "فروشگاه",
                    Address = "دانشگاه شاهد",
                    Email = "alibabarahaei@gmail.com",
                };
            }
            return View("SiteFooter");
        }
    }

    #endregion

    #region home sliders

    public class HomeSliderViewComponent : ViewComponent
    {
        private readonly ISiteService _siteService;

        public HomeSliderViewComponent(ISiteService siteService)
        {
            _siteService = siteService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sliders = await _siteService.GetAllActiveSliders();
            return View("HomeSlider", sliders);
        }
    }

    #endregion

    #region user order

    public class UserOrderViewComponent : ViewComponent
    {
        private readonly IOrderService _orderService;

        public UserOrderViewComponent(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // var openOrder = await _orderService.GetUserLatestOpenOrder(User.GetUserId());
            var openOrder = await _orderService.GetUserOpenOrderDetail(User.GetUserId());
            return View("UserOrder", openOrder);
        }
    }

    #endregion
}
