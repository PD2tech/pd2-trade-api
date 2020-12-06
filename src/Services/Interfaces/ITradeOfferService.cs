using System.Collections.Generic;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data.ResponseModel;
using Pd2TradeApi.Server.Models.DatabaseModels;

namespace Pd2TradeApi.Server.Services.Interfaces
{
    public interface ITradeOfferService
    {
        Task<List<TradeOfferResponse>> GetTradeOffers();
        Task<List<TradeOfferResponse>> SearchTradeOffers(string expression, string orderByExpression);
        Task<TradeOfferResponse> FindTradeOffer(string expression);
        Task<TradeOfferResponse> GetById(long id);
        Task<TradeOfferResponse> CreateTradeOffer(CreateTradeOfferRequest tradeOffer, long userId);
        Task<TradeOfferResponse> UpdateTradeOffer(UpdateTradeOfferRequest tradeOffer, long userId);
        Task<bool> DeleteTradeOffer(long id);
    }
}