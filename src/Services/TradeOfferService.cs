using AutoMapper;
using Lib.Exceptions;
using Pd2TradeApi.Server.Data.Interfaces;
using Pd2TradeApi.Server.Models.DatabaseModels;
using Pd2TradeApi.Server.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pd2TradeApi.Server.Services
{
    public class TradeOfferService : ITradeOfferService
    {
         private readonly ITradeOfferRepository _tradeOfferRepository;
        private readonly IMapper _mapper;

        public TradeOfferService(ITradeOfferRepository tradeOfferRepository, IMapper mapper)
        {
            _tradeOfferRepository = tradeOfferRepository;
            _mapper = mapper;
        }

        public async Task<TradeOfferResponse> FindTradeOffer(string expression)
        {
            var response = await _tradeOfferRepository.SearchAsync(expression);
            return _mapper.Map<TradeOfferResponse>(response);
        }

        public async Task<List<TradeOfferResponse>> SearchTradeOffers(string expression, string orderByExpression)
        {
            var response = await _tradeOfferRepository.SearchAllAsync(expression, orderByExpression);
            return _mapper.Map<List<TradeOfferResponse>>(response);
        }

        public async Task<List<TradeOfferResponse>> GetTradeOffers()
        {
            var response = await _tradeOfferRepository.AllAsync();
            return _mapper.Map<List<TradeOfferResponse>>(response);
        }

        public async Task<TradeOfferResponse> GetById(long id)
        {
            var response = await _tradeOfferRepository.GetByIdAsync(id);
            return _mapper.Map<TradeOfferResponse>(response);
        }

        public async Task<TradeOfferResponse> CreateTradeOffer(CreateTradeOfferRequest tradeOffer, long userId)
        {
            var tradeOfferToCreate = _mapper.Map<TradeOffer>(tradeOffer);
            tradeOfferToCreate.PosterId = userId;
            //TODO: Create bridging table records
            await _tradeOfferRepository.AddAsync(tradeOfferToCreate);
            return _mapper.Map<TradeOfferResponse>(tradeOffer);
        }

        public async Task<TradeOfferResponse> UpdateTradeOffer(UpdateTradeOfferRequest tradeOffer, long userId)
        {
            var tradeOfferToUpdate = _mapper.Map<TradeOffer>(tradeOffer);
            CheckPermissions(tradeOffer.Id, userId);
            await _tradeOfferRepository.UpdateAsync(tradeOffer.Id, tradeOfferToUpdate);
            return _mapper.Map<TradeOfferResponse>(tradeOffer);
        }

        public async Task<bool> DeleteTradeOffer(long id)
        {
            return await _tradeOfferRepository.DeleteAsync(id);
        }

        private async Task CheckPermissions(long tradeOfferId, long userId)
        {
            var tradeOfferBeingUpdated = await _tradeOfferRepository.GetByIdAsync(tradeOfferId);
            if (tradeOfferBeingUpdated.PosterId != userId)
            {
                throw new NotAllowedException("You may only update your trade offers");
            }
        }
    }
}
