using System.Collections.Generic;
using System.Threading.Tasks;
using Pd2TradeApi.Server.Models.DatabaseModels;

namespace Pd2TradeApi.Server.Data.Interfaces
{
    public interface IItemItemStatRepository
    {
        Task<ItemItemStat> AddAsync(ItemItemStat itemItemStat);
        Task<List<ItemItemStat>> AddMultipleAsync(List<ItemItemStat> itemItemStats);
        Task UpdateAsync(ItemItemStat itemItemStat);
        Task<bool> DeleteAsync(long itemStatId, long itemId);
        Task<ItemItemStat> GetByIdsAsync(long itemStatId, long itemId);
        Task<ItemItemStat> SearchAsync(string expression);
        Task<List<ItemItemStat>> SearchAllAsync(string expression);
    }
}
