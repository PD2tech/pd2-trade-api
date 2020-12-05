using System.Collections.Generic;
using System.Threading.Tasks;
using Pd2TradeApi.Server.Models.DatabaseModels;

namespace Pd2TradeApi.Server.Data.Interfaces
{
    public interface IItemStatTradeOfferRepository {
        Task<ItemStatTradeOffer> AddAsync(ItemStatTradeOffer itemStatTradeOffer);
        Task<List<ItemStatTradeOffer>> AddMultipleAsync(List<ItemStatTradeOffer> itemStatTradeOffers);
        Task UpdateAsync(ItemStatTradeOffer itemStatTradeOffer);
        Task<bool> DeleteAsync(long itemStatId, long tradeOfferId);
        Task<ItemStatTradeOffer> GetByIdsAsync(long itemStatId, long tradeOfferId);
        Task<ItemStatTradeOffer> SearchAsync(string expression);
        Task<List<ItemStatTradeOffer>> SearchAllAsync(string expression);
    }
}
