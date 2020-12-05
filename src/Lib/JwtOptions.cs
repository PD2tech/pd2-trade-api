using Microsoft.IdentityModel.Tokens;

namespace Pd2TradeApi.Server.Lib
{
    public class JwtOptions
    {
        public SigningCredentials SigningCredentials { get; set; }
    }
}
