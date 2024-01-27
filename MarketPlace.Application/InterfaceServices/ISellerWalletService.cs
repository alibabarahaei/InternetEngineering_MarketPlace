using MarketPlace.Application.DTOs.SellerWallet;
using MarketPlace.Domain.Models.Wallet;

namespace MarketPlace.Application.InterfaceServices
{
    public interface ISellerWalletService
    {
        #region wallet

        Task<FilterSellerWalletDTO> FilterSellerWallet(FilterSellerWalletDTO filter);
        Task AddWallet(SellerWallet wallet);

        #endregion
    }
}