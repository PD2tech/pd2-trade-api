using System.Collections.Generic;
using System.Threading.Tasks;
using Pd2TradeApi.Server.Models.DatabaseModels;
using Pd2TradeApi.Server.Models.DTOs.ItemStat.Request;

namespace Pd2TradeApi.Server.Services.Interfaces
{
    public interface IItemStatService
    {
        Task<List<ItemStatResponse>> GetItemStats();
        Task<List<ItemStatResponse>> SearchItemStats(string expression, string orderByExpression);
        Task<ItemStatResponse> FindItemStat(string expression);
        Task<ItemStatResponse> GetById(long id);
        Task<ItemStatResponse> CreateItemStat(CreateItemStatRequest itemStat);
        Task<ItemStatResponse> UpdateItemStat(UpdateItemStatRequest itemStat);
        Task<List<ItemStatResponse>> CreateOrUpdateItemStats(List<CreateItemStatRequest> createItemStatRequest);
        Task<bool> DeleteItemStat(long id);
    }
}