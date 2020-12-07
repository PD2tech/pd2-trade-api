using AutoMapper;
using Pd2TradeApi.Server.Models.DatabaseModels;
using Pd2TradeApi.Server.Models.DTOs.Runeword.Request;

namespace ChicksGold.Server.Api.Profiles
{
    public class RunewordProfile : Profile
    {
        public RunewordProfile()
        {
            CreateMap<Runeword, CreateRunewordRequest>().ReverseMap();
            CreateMap<Runeword, RunewordResponse>().ReverseMap();
            CreateMap<Runeword, UpdateRunewordRequest>().ReverseMap();
            CreateMap<RunewordResponse, CreateRunewordRequest>().ReverseMap();
        }
    }
}
