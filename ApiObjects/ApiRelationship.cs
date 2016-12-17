using Newtonsoft.Json;

namespace Steam.ApiObjects
{
    internal class ApiRelationship
    {
        [JsonProperty("steamid")]
        public string Id { get; set; }
        [JsonProperty("relationship")]
        public string RelationshipType { get; set; }
        [JsonProperty("friend_since")]
        public int FriendSince { get; set; }

        internal ApiRelationship() { }
    }
}
