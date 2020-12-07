using System.Collections.Generic;
using System.Threading.Tasks;
using Pd2TradeApi.Server.Models.DTOs.ItemStat.Request;

namespace Pd2TradeApi.Server.Services.Interfaces
{
    public interface IItemService
    {
        Task<List<ItemResponse>> GetItems();
        Task<List<ItemResponse>> SearchItems(string expression, string orderByExpression);
        Task<ItemResponse> FindItem(string expression);
        Task<ItemResponse> GetById(long id);
        Task<ItemResponse> CreateItem(CreateItemRequest item);
        Task<ItemResponse> UpdateItem(UpdateItemRequest item);
        Task<List<ItemResponse>> CreateOrUpdateItems(List<CreateItemRequest> createItemsRequest);
        Task<bool> DeleteItem(long id);
    }
}