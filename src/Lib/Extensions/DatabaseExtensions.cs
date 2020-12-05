using Pd2TradeApi.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pd2TradeApi.Server.Configuration;

namespace Pd2TradeApi.Server.Lib.Extensions
{
    public static class DatabaseExtensions
    {
        public static IHost Migrate(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var dbContext = scope.ServiceProvider.GetRequiredService<Pd2TradeApiDbContext>();
            dbContext.Database.Migrate();

            return host;
        }

        public static IHost Seed(this IHost webHost) {
            using (var scope = webHost.Services.GetService<IServiceScopeFactory>().CreateScope()) {
                using (var dbContext = scope.ServiceProvider.GetRequiredService<Pd2TradeApiDbContext>()) {
                    Seeder.SeedDataAsync(scope, dbContext).GetAwaiter().GetResult();
                }
            }

            return webHost;
        }

        public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Pd2TradeApiDbContext>(options =>
            {
                var connectionString = configuration.DbConnectionString();

                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            });
        }
    }
}
