using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Application.DTOs.Site
{
    public class CreateSiteSettingDTO
    {

    
        public string? Mobile { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public string? FooterText { get; set; }

       
        public string? CopyRight { get; set; }

       
        public string? MapScript { get; set; }

       
        public string AboutUs { get; set; }

     
        public string? Address { get; set; }

      
        public bool IsDefault { get; set; }
    }
}
