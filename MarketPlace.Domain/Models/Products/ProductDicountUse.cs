using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Domain.Models.Products
{
    public class ProductDiscountUse : BaseEntity
    {

        public long ProductDiscountId { get; set; }
        public long UserId { get; set; }

        public User User { get; set; }
        public ProductDiscount ProductDiscount { get; set; }

        
    }
}
