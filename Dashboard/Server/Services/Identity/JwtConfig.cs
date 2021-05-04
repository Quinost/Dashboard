using System.Text.Json.Serialization;

namespace Dashboard.Server.Services.Identity
{
    public class JwtConfig
    {
        [JsonPropertyName("Secret")]
        public string Secret { get; set; }

        [JsonPropertyName("Issuer")]
        public string Issuer { get; set; }

        [JsonPropertyName("Audience")]
        public string Audience { get; set; }

        [JsonPropertyName("AccessTokenExpiration")]
        public int AccessTokenExpiration { get; set; }

        [JsonPropertyName("RefreshTokenExpiration")]
        public int RefreshTokenExpiration { get; set; }
    }
}
