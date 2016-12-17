using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Newtonsoft.Json;
using Steam.DataTypes;
using Steam.ApiObjects;

namespace Steam
{
    public class User
    {
        private ISteamClient _client;
        
        public string Id { get; private set; }

        public async Task<IEnumerable<Relationship>> GetRelationshipsAsync()
        {
            string response = await WebHelper.DownloadStringAsync($"http://api.steampowered.com/ISteamUser/GetFriendList/v0001/?key={_client.Key}&steamid={Id}");
            return GetRelationships(response);
        }

        public async Task<Library> GetLibraryAsync()
        {
            string response = await WebHelper.DownloadStringAsync($"http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key={_client.Key}&steamid={Id}&format=json&include_appinfo=1");
            var result = JsonConvert.DeserializeAnonymousType(response, new { Response = new ApiLibrary() });
            return new Library(result.Response);
        }

        private IEnumerable<Relationship> GetRelationships(string json)
        {
            var result = JsonConvert.DeserializeAnonymousType(json, new { FriendsList = new { Friends = new ApiRelationship[0] } });
            foreach (var r in result.FriendsList.Friends)
                yield return new Relationship(this, r);
        }

        internal User(ISteamClient client, string id)
        {
            _client = client;
            Id = id;
        }
    }
}
