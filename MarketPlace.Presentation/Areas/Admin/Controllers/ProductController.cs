﻿using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Presentation.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}