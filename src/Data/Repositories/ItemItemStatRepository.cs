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
    public class ItemItemStatRepository : IItemItemStatRepository
    {
        protected readonly Pd2TradeApiDbContext Db;
        private readonly IMapper _mapper;
        protected DbSet<ItemItemStat> Table => Db.Set<ItemItemStat>();

        public ItemItemStatRepository(Pd2TradeApiDbContext db, IMapper mapper)
        {
            Db = db;
            _mapper = mapper;
        }

        public virtual async Task<ItemItemStat> AddAsync(ItemItemStat ItemItemStat)
        {
            CreatePropertyIgnore(ItemItemStat);
            await Db.AddAsync(ItemItemStat);
            await Db.SaveChangesAsync();
            return ItemItemStat;
        }
        public virtual async Task<List<ItemItemStat>> AddMultipleAsync(List<ItemItemStat> ItemItemStats)
        {
            await Db.BulkInsertAsync(ItemItemStats);
            return ItemItemStats;
        }

        public async Task UpdateAsync(ItemItemStat ItemItemStat)
        {
            try
            {
                Db.Update(ItemItemStat);
                await Db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> DeleteAsync(long itemStatId, long itemId)
        {
            var entity = await GetByIdsAsync(itemStatId, itemId);
            if (entity == null)
            {
                return false;
            }
            Db.Remove(entity);
            await Db.SaveChangesAsync();
            return true;
        }

        public virtual async Task<ItemItemStat> GetByIdsAsync(long itemStatId, long itemId)
        {
            return await Table.Where(x => x.ItemStatId == itemStatId && x.ItemId == itemId).SingleOrDefaultAsync();
        }

        public async Task<ItemItemStat> SearchAsync(string expression)
        {
            return await Table.Where(expression).FirstOrDefaultAsync();
        }
        public async Task<List<ItemItemStat>> SearchAllAsync(string expression)
        {
            return await Table.Where(expression).ToListAsync();
        }
        protected virtual void UpdatePropertyIgnore(ItemItemStat entity) { }
        protected virtual void CreatePropertyIgnore(ItemItemStat entity) { }
    }
}
