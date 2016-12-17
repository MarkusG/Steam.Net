using Newtonsoft.Json;

namespace Steam.ApiObjects
{
    internal class ApiGame
    {
        [JsonProperty("appid")]
        public int Id { get; private set; }
        [JsonProperty("name")]
        public string Name { get; private set; }
        [JsonProperty("playtime_forever")]
        public int PlaytimeForever { get; private set; }
        [JsonProperty("playtime_2weeks")]
        public int Playtime2Weeks { get; private set; }
        [JsonProperty("img_icon_url")]
        public string IconUrl { get; private set; }
        [JsonProperty("img_logo_url")]
        public string LogoUrl { get; private set; }
        [JsonProperty("has_community_visible_stats")]
        public bool HasCommunityStats { get; private set; }
    }
}
