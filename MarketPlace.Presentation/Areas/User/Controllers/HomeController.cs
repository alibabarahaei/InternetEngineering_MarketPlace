﻿using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Presentation.Areas.User.Controllers
{
    public class HomeController : UserBaseController
    {
        #region constructor



        #endregion

        #region user dashboard

        [HttpGet("")]
        public async Task<IActionResult> Dashboard()
        {
            return View();
        }

        #endregion
    }
}
