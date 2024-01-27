using MarketPlace.Domain.Models.Common;
using MarketPlace.Domain.Models.User;

namespace MarketPlace.Domain.Models.Products
{
    public class ProductDiscountUse : BaseEntity
    {
        #region properties

        public long ProductDiscountId { get; set; }

        public long UserId { get; set; }

        #endregion

        #region relations

        public ApplicationUser User { get; set; }
        public ProductDiscount ProductDiscount { get; set; }

        #endregion
    }
}
