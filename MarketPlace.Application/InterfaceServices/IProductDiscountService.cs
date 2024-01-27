namespace MarketPlace.Application.InterfaceServices
{
    public interface IProductDiscountService : IAsyncDisposable
    {
        #region product discount

        Task<FilterProductDiscountDTO> FilterProductDiscount(FilterProductDiscountDTO filter);

        Task<CreateDiscountResult> CreateProductDiscount(CreateProductDiscountDto discount, long sellerId);

        #endregion
    }
}