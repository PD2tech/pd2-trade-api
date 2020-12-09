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
        private readonly IItemStatTradeOfferRepository _itemStatTradeOfferRepository;
        private readonly IItemRepository _itemRepository;
        private readonly IItemItemStatRepository _itemItemStatRepository;

        public TradeOfferService(
            ITradeOfferRepository tradeOfferRepository,
            IMapper mapper,
            IItemStatTradeOfferRepository itemStatTradeOfferRepository,
            IItemRepository itemRepository,
            IItemItemStatRepository itemItemStatRepository)
        {
            _tradeOfferRepository = tradeOfferRepository;
            _mapper = mapper;
            _itemStatTradeOfferRepository = itemStatTradeOfferRepository;
            _itemRepository = itemRepository;
            _itemItemStatRepository = itemItemStatRepository;
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
            return await _tradeOfferRepository.GetLatestTradeOffers<TradeOfferResponse>();
        }

        public async Task<TradeOfferResponse> GetById(long id)
        {
            var response = await _tradeOfferRepository.GetByIdAsync(id);
            return _mapper.Map<TradeOfferResponse>(response);
        }

        public async Task<TradeOfferResponse> FiterTradeOffers(FilterTradeOffersRequest filterRequest)
        {
            var response = await _tradeOfferRepository.FilterTradeOffers(filterRequest);
            return _mapper.Map<TradeOfferResponse>(response);
        }

        public async Task<TradeOfferResponse> CreateTradeOffer(CreateTradeOfferRequest tradeOffer, long userId)
        {
            var tradeOfferToCreate = _mapper.Map<TradeOffer>(tradeOffer);
            tradeOfferToCreate.PosterId = userId;

            //if (tradeOffer.OfferedItemId == null)
            //{
            //    var itemToCreate = _mapper.Map<Item>(tradeOffer.OfferedItem);
            //    await _itemRepository.AddAsync(itemToCreate);
            //    tradeOfferToCreate.OfferedItemId = itemToCreate.Id;
            //}

            await _tradeOfferRepository.AddAsync(tradeOfferToCreate);

            var stats = new List<ItemStatTradeOffer>();
            var itemStats = new List<ItemItemStat>();
            foreach (var stat in tradeOffer.OfferedItem.Stats)
            {
                stats.Add(new ItemStatTradeOffer {
                    ItemStatId = stat.Id,
                    TradeOfferId = tradeOfferToCreate.Id,
                    Value = stat.Value
                });
                itemStats.Add(new ItemItemStat
                {
                    ItemStatId = stat.Id,
                    ItemId = (long) tradeOfferToCreate.OfferedItemId
                });
            }
            await _itemItemStatRepository.AddMultipleAsync(itemStats);
            await _itemStatTradeOfferRepository.AddMultipleAsync(stats);

            await _tradeOfferRepository.UpdateAsync(tradeOfferToCreate.Id, tradeOfferToCreate);
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
