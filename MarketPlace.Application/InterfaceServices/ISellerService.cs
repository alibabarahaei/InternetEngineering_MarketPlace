using MarketPlace.Application.DTOs.Common;
using MarketPlace.Application.DTOs.Seller;
using MarketPlace.Domain.Models.Store;

namespace MarketPlace.Application.InterfaceServices
{
    public interface ISellerService : IAsyncDisposable
    {
        #region seller

        Task<RequestSellerResult> AddNewSellerRequest(RequestSellerDTO seller, long userId);
        Task<FilterSellerDTO> FilterSellers(FilterSellerDTO filter);
        Task<EditRequestSellerDTO> GetRequestSellerForEdit(long id, long currentUserId);
        Task<EditRequestSellerResult> EditRequestSeller(EditRequestSellerDTO request, long currentUserId);
        Task<bool> AcceptSellerRequest(long requestId);
        Task<bool> RejectSellerRequest(RejectItemDTO reject);
        Task<Seller> GetLastActiveSellerByUserId(long userId);
        Task<bool> HasUserAnyActiveSellerPanel(long userId);

        #endregion
    }
}