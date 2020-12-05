using AutoMapper;
using Pd2TradeApi.Server.Models;
using Pd2TradeApi.Server.Models.DatabaseModels;

namespace ChicksGold.Server.Api.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserResponse>().ReverseMap();
        }
    }
}
