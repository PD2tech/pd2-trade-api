using System.IO;
using Pd2TradeApi.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Pd2TradeApi.Server.Configuration;

namespace Pd2TradeApi.Server.Api
{
    public class Pd2TradeApiDbFactory : IDesignTimeDbContextFactory<Pd2TradeApiDbContext>
    {
        public Pd2TradeApiDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.Development.json")
                .Build();

            var builder = new DbContextOptionsBuilder<Pd2TradeApiDbContext>();

            var connectionString = configuration.DbConnectionString();
            builder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), (options) => { 
                options.EnableRetryOnFailure();
            });

            return new Pd2TradeApiDbContext(builder.Options);
        }
    }
}
