﻿using MarketPlace.Application.DTOs.Paging;

namespace MarketPlace.Application.DTOs.ProductDiscount
{
    public class FilterProductDiscountDTO : BasePaging
    {
        #region properties

        public long? ProductId { get; set; }

        public long? SellerId { get; set; }

        public List<Domain.Models.Products.ProductDiscount> ProductDiscounts { get; set; }

        #endregion

        #region methods

        public FilterProductDiscountDTO SetDiscounts(List<Domain.Models.Products.ProductDiscount> productDiscounts)
        {
            this.ProductDiscounts = productDiscounts;
            return this;
        }

        public FilterProductDiscountDTO SetPaging(BasePaging paging)
        {
            this.PageId = paging.PageId;
            this.AllEntitiesCount = paging.AllEntitiesCount;
            this.StartPage = paging.StartPage;
            this.EndPage = paging.EndPage;
            this.HowManyShowPageAfterAndBefore = paging.HowManyShowPageAfterAndBefore;
            this.TakeEntity = paging.TakeEntity;
            this.SkipEntity = paging.SkipEntity;
            this.PageCount = paging.PageCount;
            return this;
        }

        #endregion
    }
}
