using AutoMapper;
using Pd2TradeApi.Server.Data.Interfaces;
using Pd2TradeApi.Server.Models.DatabaseModels;
using Pd2TradeApi.Server.Models.DTOs.ItemStat.Request;
using Pd2TradeApi.Server.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pd2TradeApi.Server.Services
{
    public class ItemStatService : IItemStatService
    {
         private readonly IItemStatRepository _itemStatRepository;
        private readonly IMapper _mapper;

        public ItemStatService(IItemStatRepository itemStatRepository, IMapper mapper)
        {
            _itemStatRepository = itemStatRepository;
            _mapper = mapper;
        }

        public async Task<ItemStatResponse> FindItemStat(string expression)
        {
            var itemStat = await _itemStatRepository.SearchAsync(expression);
            return _mapper.Map<ItemStatResponse>(itemStat);
        }

        public async Task<List<ItemStatResponse>> SearchItemStats(string expression, string orderByExpression)
        {
            var itemStats = await _itemStatRepository.SearchAllAsync(expression, orderByExpression);
            return _mapper.Map<List<ItemStatResponse>>(itemStats);
        }

        public async Task<List<ItemStatResponse>> GetItemStats()
        {
            var itemStat = await _itemStatRepository.AllAsync();
            return _mapper.Map<List<ItemStatResponse>>(itemStat);
        }

        public async Task<ItemStatResponse> GetById(long id)
        {
            var itemStat = await _itemStatRepository.GetByIdAsync(id);
            return _mapper.Map<ItemStatResponse>(itemStat);
        }

        public async Task<ItemStatResponse> CreateItemStat(CreateItemStatRequest createItemStatRequest)
        {
            var itemStat = _mapper.Map<ItemStat>(createItemStatRequest);
            await _itemStatRepository.AddAsync(itemStat);
            return _mapper.Map<ItemStatResponse>(itemStat);
        }

        public async Task<List<ItemStatResponse>> CreateOrUpdateItemStats(List<CreateItemStatRequest> createItemStatsRequest)
        {
            var itemStatsToUpdate = new List<CreateItemStatRequest>();
            var itemStatsToCreate = new List<CreateItemStatRequest>();
            var allItemStates = await _itemStatRepository.AllAsync();
            foreach (var itemStat in createItemStatsRequest)
            {
                ItemStat foundItemStat = allItemStates.Find(x => x.Code == itemStat.Code);
                if (foundItemStat != null)
                {
                    itemStat.Id = foundItemStat.Id;
                    itemStatsToUpdate.Add(itemStat);
                } else
                {
                    itemStatsToCreate.Add(itemStat);
                }
            }
            await _itemStatRepository.AddMultipleAsync(_mapper.Map<List<ItemStat>>(itemStatsToCreate));
            await _itemStatRepository.BulkUpdate(_mapper.Map<List<ItemStat>>(itemStatsToUpdate));

            return _mapper.Map<List<ItemStatResponse>>(createItemStatsRequest);
        }


        public async Task<ItemStatResponse> UpdateItemStat(UpdateItemStatRequest updateItemStatRequest)
        {
            var itemStat = _mapper.Map<ItemStat>(updateItemStatRequest);
            await _itemStatRepository.UpdateAsync(itemStat.Id, itemStat);

            return _mapper.Map<ItemStatResponse>(itemStat);
        }

        public async Task<ItemStatResponse> UpdateItemStats(List<UpdateItemStatRequest> updateItemStatsRequest)
        {
            var itemStat = _mapper.Map<ItemStat>(updateItemStatsRequest);
            await _itemStatRepository.UpdateAsync(itemStat.Id, itemStat);

            return _mapper.Map<ItemStatResponse>(itemStat);
        }

        public async Task<bool> DeleteItemStat(long id)
        {
            return await _itemStatRepository.DeleteAsync(id);
        }
    }
}
