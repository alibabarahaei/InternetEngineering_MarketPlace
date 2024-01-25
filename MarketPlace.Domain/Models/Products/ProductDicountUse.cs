using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Domain.Models.Products
{
    public class ProductDiscountUse : BaseEntity
    {
        #region properties

        public long ProductDiscountId { get; set; }

        public long UserId { get; set; }

        #endregion

        #region relations

        public User User { get; set; }
        public ProductDiscount ProductDiscount { get; set; }

        #endregion
    }
}
