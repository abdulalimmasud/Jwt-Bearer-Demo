using System;
using Microsoft.IdentityModel.Tokens;

namespace JwtBearerDemo.Middleware
{
    public class TokenProviderOptions
    {
        public string Path { get; set; } = "/token";
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public SigningCredentials SigningCredentials { get; set; }
        public TimeSpan Expiration { get; internal set; }
    }
}
