using System;
using System.Collections.Generic;
using System.Text;
using Steam.ApiObjects;

namespace Steam.DataTypes
{
    public class Relationship
    {
        public string From { get; private set; }

        public string To { get; private set; }

        public DateTime Since { get; private set; }

        public string Type { get; private set; }

        internal Relationship(User u, ApiRelationship r)
        {
            From = u.Id;
            To = r.Id;
            Since = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(r.FriendSince);
            Type = r.RelationshipType;
        }
    }
}
