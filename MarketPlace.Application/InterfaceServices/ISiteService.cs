using MarketPlace.Domain.Models.Site;

namespace MarketPlace.Application.InterfaceServices
{
    public interface ISiteService : IAsyncDisposable
    {
        #region site settings

        Task<SiteSetting> GetDefaultSiteSetting();

        #endregion

        #region slider

        Task<List<Slider>> GetAllActiveSliders();

        #endregion

        #region site banners

        Task<List<SiteBanner>> GetSiteBannersByPlacement(List<BannerPlacement> placements);

        #endregion
    }
}