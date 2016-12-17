using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Newtonsoft.Json;
using Steam.ResponseObjects;
using Steam.DataTypes;

namespace Steam
{
    public class User
    {
        private ISteamClient _client;
        
        public string Id { get; private set; }

        public async Task<Library> GetLibraryAsync()
        {
            string response = await WebHelper.DownloadStringAsync($"http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key={_client.Key}&steamid={Id}&format=json&include_appinfo=1");
            var result = JsonConvert.DeserializeAnonymousType(response, new { Response = new ApiLibrary() });
            return new Library(result.Response);
        }

        internal User(ISteamClient client, string id)
        {
            _client = client;
            Id = id;
        }
    }
}
