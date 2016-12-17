using System;
using Steam.ResponseObjects;

namespace Steam.DataTypes
{
    public class Game
    {
        private int _playtimeForeverMinutes;
        private int _playtime2WeeksMinutes;
        private string _iconurl;
        private string _logourl;

        public int Id { get; private set; }

        public string Name { get; private set; }

        public bool HasCommunityStats { get; private set; }

        public TimeSpan PlaytimeForever
        {
            get
            {
                return TimeSpan.FromMinutes(_playtimeForeverMinutes);
            }
        }

        public TimeSpan Playtime2Weeks
        {
            get
            {
                return TimeSpan.FromMinutes(_playtime2WeeksMinutes);
            }
        }

        public string IconUrl
        {
            get
            {
                return $"http://media.steampowered.com/steamcommunity/public/images/apps/{Id}/{_iconurl}.jpg";
            }
        }

        public string LogoUrl
        {
            get
            {
                return $"http://media.steampowered.com/steamcommunity/public/images/apps/{Id}/{_logourl}.jpg";
            }
        }

        internal Game(ApiGame g)
        {
            Id = g.Id;
            Name = g.Name;
            HasCommunityStats = g.HasCommunityStats;
            _playtimeForeverMinutes = g.PlaytimeForever;
            _playtime2WeeksMinutes = g.Playtime2Weeks;
            _iconurl = g.IconUrl;
            _logourl = g.LogoUrl;
        }
    }
}
