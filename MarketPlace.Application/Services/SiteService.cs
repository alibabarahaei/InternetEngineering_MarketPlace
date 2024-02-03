using MarketPlace.Application.DTOs.Site;
using MarketPlace.Application.InterfaceServices;
using MarketPlace.Domain.InterfaceRepository;
using MarketPlace.Domain.Models.Site;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace.Application.Services
{
    public class SiteService : ISiteService
    {
        #region constructor

        private readonly IGenericRepository<SiteSetting> _siteSettingRepository;
        private readonly IGenericRepository<Slider> _sliderRepository;
        private readonly IGenericRepository<SiteBanner> _bannerRepository;

        public SiteService(IGenericRepository<SiteSetting> siteSettingRepository, IGenericRepository<Slider> sliderRepository, IGenericRepository<SiteBanner> bannerRepository)
        {
            _siteSettingRepository = siteSettingRepository;
            _sliderRepository = sliderRepository;
            _bannerRepository = bannerRepository;
        }

        #endregion

        #region site settings

        public async Task<SiteSetting> GetDefaultSiteSetting()
        {
            return await _siteSettingRepository.GetQuery().AsQueryable()
                .SingleOrDefaultAsync(s => s.IsDefault && !s.IsDelete);
        }

        public void AddSiteSetting(CreateSiteSettingDTO createSiteSettingDto)
        {
            _siteSettingRepository.AddEntity(new SiteSetting()
            {
                AboutUs = createSiteSettingDto.AboutUs,
                Address = createSiteSettingDto.Address,
                CopyRight = createSiteSettingDto.CopyRight,
                Email = createSiteSettingDto.Email,
                FooterText = createSiteSettingDto.FooterText,
                IsDefault = createSiteSettingDto.IsDefault,
                MapScript = createSiteSettingDto.MapScript,
                Phone = createSiteSettingDto.Phone,
                Mobile = createSiteSettingDto.Mobile
            });
            _siteSettingRepository.SaveChanges();
        }

        #endregion

        #region slider

        public async Task<List<Slider>> GetAllActiveSliders()
        {
            return await _sliderRepository.GetQuery().AsQueryable()
                .Where(s => s.IsActive && !s.IsDelete).ToListAsync();
        }

        #endregion

        #region site banners

        public async Task<List<SiteBanner>> GetSiteBannersByPlacement(List<BannerPlacement> placements)
        {
            return await _bannerRepository.GetQuery().AsQueryable()
                .Where(s => placements.Contains(s.BannerPlacement)).ToListAsync();
        }

        #endregion

        #region dispose

        public async ValueTask DisposeAsync()
        {
            if (_siteSettingRepository != null) await _siteSettingRepository.DisposeAsync();
            if (_sliderRepository != null) await _sliderRepository.DisposeAsync();
            if (_bannerRepository != null) await _bannerRepository.DisposeAsync();
        }

        #endregion
    }
}
