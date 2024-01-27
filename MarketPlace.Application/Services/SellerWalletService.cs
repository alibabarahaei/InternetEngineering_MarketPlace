﻿using MarketPlace.Application.DTOs.Paging;
using MarketPlace.Application.DTOs.SellerWallet;
using MarketPlace.Application.InterfaceServices;
using MarketPlace.Domain.InterfaceRepository;
using MarketPlace.Domain.Models.Wallet;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace.Application.Services
{
    public class SellerWalletService : ISellerWalletService
    {
        #region constructor

        private readonly IGenericRepository<SellerWallet> _sellerWalletRepository;

        public SellerWalletService(IGenericRepository<SellerWallet> sellerWalletRepository)
        {
            _sellerWalletRepository = sellerWalletRepository;
        }

        #endregion

        #region wallet

        public async Task<FilterSellerWalletDTO> FilterSellerWallet(FilterSellerWalletDTO filter)
        {
            var query = _sellerWalletRepository.GetQuery().AsQueryable();

            if (filter.SellerId != null && filter.SellerId != 0)
            {
                query = query.Where(s => s.SellerId == filter.SellerId.Value);
            }

            if (filter.PriceFrom != null)
            {
                query = query.Where(s => s.Price >= filter.PriceFrom.Value);
            }

            if (filter.PriceTo != null)
            {
                query = query.Where(s => s.Price <= filter.PriceTo.Value);
            }

            var allEntitiesCount = await query.CountAsync();

            var pager = Pager.Build(filter.PageId, allEntitiesCount, filter.TakeEntity, filter.HowManyShowPageAfterAndBefore);

            var wallets = await query.Paging(pager).ToListAsync();

            return filter.SetSellerWallets(wallets).SetPaging(pager);
        }

        public async Task AddWallet(SellerWallet wallet)
        {
            await _sellerWalletRepository.AddEntity(wallet);
            await _sellerWalletRepository.SaveChanges();
        }

        #endregion
    }
}
