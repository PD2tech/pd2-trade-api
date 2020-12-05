using Microsoft.Extensions.Configuration;

namespace Pd2TradeApi.Server.Configuration
{
    public static class ConfigurationExtensions
    {
        public static string DbConnectionString(this IConfiguration configuration)
            => configuration.GetConnectionString("Pd2TradeApiDb") ?? configuration["Pd2TradeApiDb"];

        public static string TelemetryKey(this IConfiguration configuration) => configuration.GetConfig("TelemetryKey");

        public static string JwtKey(this IConfiguration configuration) =>
            configuration.GetConfig("JwtKey");

        private static string GetConfig(this IConfiguration configuration, string key)
        {
            return configuration[key];
        }
    }
}
