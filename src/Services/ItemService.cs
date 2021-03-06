﻿using AutoMapper;
using Pd2TradeApi.Server.Data.Interfaces;
using Pd2TradeApi.Server.Models.DatabaseModels;
using Pd2TradeApi.Server.Models.DTOs.Item.Request;
using Pd2TradeApi.Server.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pd2TradeApi.Server.Services
{
    public class ItemService : IItemService
    {
         private readonly IItemRepository _itemRepository;
        private readonly IMapper _mapper;

        public ItemService(IItemRepository itemRepository, IMapper mapper)
        {
            _itemRepository = itemRepository;
            _mapper = mapper;
        }

        public async Task<ItemResponse> FindItem(string expression)
        {
            var response = await _itemRepository.SearchAsync(expression);
            return _mapper.Map<ItemResponse>(response);
        }

        public async Task<List<ItemResponse>> SearchItems(string expression, string orderByExpression)
        {
            var response = await _itemRepository.SearchAllAsync(expression, orderByExpression);
            return _mapper.Map<List<ItemResponse>>(response);
        }

        public async Task<List<ItemResponse>> GetItems()
        {
            var response = await _itemRepository.AllAsync();
            return _mapper.Map<List<ItemResponse>>(response);
        }

        public async Task<ItemResponse> GetById(long id)
        {
            var response = await _itemRepository.GetByIdAsync(id);
            return _mapper.Map<ItemResponse>(response);
        }

        public async Task<ItemResponse> CreateItem(CreateItemRequest item)
        {
            await _itemRepository.AddAsync(_mapper.Map<Item>(item));
            return _mapper.Map<ItemResponse>(item);
        }

        public async Task<ItemResponse> UpdateItem(UpdateItemRequest item)
        {
            await _itemRepository.UpdateAsync(item.Id, _mapper.Map<Item>(item));
            return _mapper.Map<ItemResponse>(item);
        }

        public async Task<List<ItemResponse>> CreateOrUpdateItems(List<CreateItemRequest> createItemsRequest)
        {
            var itemsToUpdate = new List<CreateItemRequest>();
            var itemsToCreate = new List<CreateItemRequest>();
            var allItems = await _itemRepository.AllAsync();
            foreach (var item in createItemsRequest)
            {
                Item foundItemStat = allItems.Find(x => x.Code == item.Code);
                if (foundItemStat != null)
                {
                    item.Id = foundItemStat.Id;
                    itemsToUpdate.Add(item);
                }
                else
                {
                    itemsToCreate.Add(item);
                }
            }
            await _itemRepository.AddMultipleAsync(_mapper.Map<List<Item>>(itemsToCreate));
            await _itemRepository.BulkUpdate(_mapper.Map<List<Item>>(itemsToUpdate));

            return _mapper.Map<List<ItemResponse>>(createItemsRequest);
        }

        public async Task<bool> DeleteItem(long id)
        {
            return await _itemRepository.DeleteAsync(id);
        }
    }
}
