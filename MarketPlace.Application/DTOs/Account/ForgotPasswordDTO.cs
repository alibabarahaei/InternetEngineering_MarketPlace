﻿using System.ComponentModel.DataAnnotations;

namespace MarketPlace.Application.DTOs.Account
{
    public class ForgotPasswordDTO 
    {
        [Display(Name = "تلفن همراه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Mobile { get; set; }
    }

    public enum ForgotPasswordResult
    {
        Success,
        NotFound,
        Error
    }
}
