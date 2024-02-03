using MarketPlace.Application.DTOs.Contacts;
using MarketPlace.Application.InterfaceServices;
using MarketPlace.Domain.Models.Site;
using MarketPlace.Presentation.Models;
using MarketPlace.Presentation.PresentationExtensions;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MarketPlace.Presentation.Controllers
{
    public class HomeController : SiteBaseController
    {
        #region constructor

        private readonly IContactService _contactService;
       
        private readonly ISiteService _siteService;
        private readonly IProductService _productService;

        public HomeController(IContactService contactService,  ISiteService siteService, IProductService productService)
        {
            _contactService = contactService;
          
            _siteService = siteService;
            _productService = productService;
        }

        #endregion

        #region index

        public async Task<IActionResult> Index()
        {
            ViewBag.banners = await _siteService
                .GetSiteBannersByPlacement(new List<BannerPlacement>
                {
                    BannerPlacement.Home_1,
                    BannerPlacement.Home_2,
                    BannerPlacement.Home_3
                });

            ViewData["OffProducts"] = await _productService.GetAllOffProducts(12);

            return View();
        }

        #endregion

        #region contact us

        [HttpGet("contact-us")]
        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost("contact-us"), ValidateAntiForgeryToken]
        public async Task<IActionResult> ContactUs(CreateContactUsDTO contact)
        {
           

            if (ModelState.IsValid)
            {
                var ip = HttpContext.GetUserIp();
                await _contactService.CreateContactUs(contact, HttpContext.GetUserIp(), User.GetUserId());
                TempData[SuccessMessage] = "???? ??? ?? ?????? ????? ??";
                return RedirectToAction("ContactUs");
            }

            return View(contact);
        }

        #endregion

        #region about us

        [HttpGet("about-us")]
        public async Task<IActionResult> AboutUs()
        {
            var siteSetting = await _siteService.GetDefaultSiteSetting();
            if (siteSetting == null)
            {
                siteSetting = new SiteSetting()
                {
                    Mobile = "09330807786",
                    IsDefault = true,
                    Phone = "09330807786",
                    AboutUs = "فروشگاه",
                    Address = "دانشگاه شاهد",
                    Email = "alibabarahaei@gmail.com",

                };
            }
            return View(siteSetting);
        }

        #endregion
    }
}
