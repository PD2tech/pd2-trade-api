using System.Collections.Generic;
using System.Threading.Tasks;
using Pd2TradeApi.Server.Data.Interfaces.Base;
using Pd2TradeApi.Server.Models.DatabaseModels;

namespace Pd2TradeApi.Server.Data.Interfaces
{
    public interface ITradeOfferRepository : IBaseRepository<TradeOffer> {
        Task<List<TradeOffer>> GetLatestTradeOffers();
        Task<List<TradeOffer>> FilterTradeOffers(FilterTradeOffersRequest filterRequest);
    }
}
