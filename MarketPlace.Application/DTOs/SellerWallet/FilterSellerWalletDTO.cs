using MarketPlace.Application.DTOs.Paging;

namespace MarketPlace.Application.DTOs.SellerWallet
{
    public class FilterSellerWalletDTO : BasePaging
    {
        public long? SellerId { get; set; }

        public int? PriceFrom { get; set; }

        public int? PriceTo { get; set; }

        public List<Domain.Models.Wallet.SellerWallet> SellerWallets { get; set; }

        public FilterSellerWalletDTO SetSellerWallets(List<Domain.Models.Wallet.SellerWallet> wallets)
        {
            SellerWallets = wallets;
            return this;
        }

        public FilterSellerWalletDTO SetPaging(BasePaging paging)
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
    }
}
