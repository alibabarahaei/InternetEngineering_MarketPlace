﻿using System.ComponentModel.DataAnnotations;

namespace MarketPlace.Application.DTOs.Common
{
    public class RejectItemDTO
    {
        public long Id { get; set; }

        [Display(Name = "توضیحات عدم تایید اطلاعات")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string RejectMessage { get; set; }
    }
}
