using AutoMapper;
using Pd2TradeApi.Server.Models.DatabaseModels;
using Pd2TradeApi.Server.Models.DTOs.Item.Request;
using Pd2TradeApi.Server.Models.DTOs.ItemStat.Request;

namespace ChicksGold.Server.Api.Profiles
{
    public class ItemStatProfile : Profile
    {
        public ItemStatProfile()
        {
            CreateMap<ItemStat, CreateItemStatRequest>().ReverseMap();
            CreateMap<ItemStat, ItemStatResponse>().ReverseMap();
            CreateMap<ItemStat, UpdateItemRequest>().ReverseMap();
            CreateMap<ItemStatResponse, CreateItemStatRequest>().ReverseMap();
        }
    }
}
