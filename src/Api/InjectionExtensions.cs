using Pd2TradeApi.Server.Api.Lib;
using Pd2TradeApi.Server.Data.Interfaces;
using Pd2TradeApi.Server.Data.Repositories;
using Pd2TradeApi.Server.Services;
using Pd2TradeApi.Server.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Pd2TradeApi.Server.Lib.Extensions
{
    public static class InjectionExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<IItemService, ItemService>();
            services.AddScoped<ITradeOfferRepository, TradeOfferRepository>();
            services.AddScoped<ITradeOfferService, TradeOfferService>();
            services.AddScoped<IItemStatRepository, ItemStatRepository>();
            services.AddScoped<IItemStatService, ItemStatService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IItemStatTradeOfferRepository, ItemStatTradeOfferRepository>();
            services.AddScoped<IItemSocketRepository, ItemSocketRepository>();
            services.AddScoped<IRunewordRepository, RunewordRepository>();
            services.AddScoped<IRunewordService, RunewordService>();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<UserResolver>();
        }
    }
}
