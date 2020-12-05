using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pd2TradeApi.Server.Data.Interfaces;
using Pd2TradeApi.Server.Models.DatabaseModels;

namespace Pd2TradeApi.Server.Data.Repositories
{
    public class ItemStatTradeOfferRepository : IItemStatTradeOfferRepository
    {
        protected readonly Pd2TradeApiDbContext Db;
        private readonly IMapper _mapper;
        protected DbSet<ItemStatTradeOffer> Table => Db.Set<ItemStatTradeOffer>();

        public ItemStatTradeOfferRepository(Pd2TradeApiDbContext db, IMapper mapper)
        {
            Db = db;
            _mapper = mapper;
        }

        public virtual async Task<ItemStatTradeOffer> AddAsync(ItemStatTradeOffer itemStatTradeOffer)
        {
            CreatePropertyIgnore(itemStatTradeOffer);
            await Db.AddAsync(itemStatTradeOffer);
            await Db.SaveChangesAsync();
            return itemStatTradeOffer;
        }
        public virtual async Task<List<ItemStatTradeOffer>> AddMultipleAsync(List<ItemStatTradeOffer> itemStatTradeOffers)
        {
            await Db.BulkInsertAsync(itemStatTradeOffers);
            return itemStatTradeOffers;
        }

        public async Task UpdateAsync(ItemStatTradeOffer itemStatTradeOffer)
        {
            try
            {
                Db.Update(itemStatTradeOffer);
                await Db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> DeleteAsync(long itemStatId, long tradeOfferId)
        {
            var entity = await GetByIdsAsync(itemStatId, tradeOfferId);
            if (entity == null)
            {
                return false;
            }
            Db.Remove(entity);
            await Db.SaveChangesAsync();
            return true;
        }

        public virtual async Task<ItemStatTradeOffer> GetByIdsAsync(long itemStatId, long tradeOfferId)
        {
            return await Table.Where(x => x.ItemStatId == itemStatId && x.TradeOfferId == tradeOfferId).SingleOrDefaultAsync();
        }

        public async Task<ItemStatTradeOffer> SearchAsync(string expression)
        {
            return await Table.Where(expression).FirstOrDefaultAsync();
        }
        public async Task<List<ItemStatTradeOffer>> SearchAllAsync(string expression)
        {
            return await Table.Where(expression).ToListAsync();
        }
        protected virtual void UpdatePropertyIgnore(ItemStatTradeOffer entity) { }
        protected virtual void CreatePropertyIgnore(ItemStatTradeOffer entity) { }
    }
}
