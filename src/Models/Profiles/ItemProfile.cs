using AutoMapper;
using Pd2TradeApi.Server.Models.DatabaseModels;
using Pd2TradeApi.Server.Models.DTOs.Item.Request;

namespace ChicksGold.Server.Api.Profiles
{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            CreateMap<Item, CreateItemRequest>().ReverseMap();
            CreateMap<Item, ItemResponse>().ReverseMap();
            CreateMap<Item, UpdateItemRequest>().ReverseMap();
            CreateMap<ItemResponse, CreateItemRequest>().ReverseMap();
            CreateMap<Item, CreateItemFromTradeRequest>().ReverseMap();
            CreateMap<Item, TradeOfferItemResponse>().ReverseMap();
            CreateMap<ItemResponse, CreateItemFromTradeRequest>().ReverseMap();
        }
    }
}
