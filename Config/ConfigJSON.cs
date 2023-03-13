using Newtonsoft.Json;

namespace DiscordBotTemplate.Config
{
    internal struct ConfigJSON
    {
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("prefix")]
        public string Prefix { get; set; }
    }
}
