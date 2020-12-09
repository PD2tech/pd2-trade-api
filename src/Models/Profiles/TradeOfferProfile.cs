using AutoMapper;
using Pd2TradeApi.Server.Models.DatabaseModels;
using Pd2TradeApi.Server.Models.DTOs.Item.Request;

namespace ChicksGold.Server.Api.Profiles
{
    public class TradeOfferProfile : Profile
    {
        public TradeOfferProfile()
        {
            CreateMap<TradeOffer, CreateTradeOfferRequest>().ReverseMap();
            CreateMap<TradeOffer, UpdateTradeOfferRequest>().ReverseMap();
            CreateMap<TradeOffer, TradeOfferResponse>().ReverseMap();
            CreateMap<TradeOfferResponse, CreateTradeOfferRequest>().ReverseMap();
        }
    }
}
