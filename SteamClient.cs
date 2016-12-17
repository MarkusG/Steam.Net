using System;

namespace Steam
{
    public class SteamClient : ISteamClient
    {
        public string Key { get; private set; }

        public User GetUser(string id)
        {
            return new User(this, id);
        }

        public SteamClient(string key)
        {
            Key = key;
        }
    }
}
