using System.Collections.Generic;
using Steam.ResponseObjects;

namespace Steam.DataTypes
{
    public class Library
    {
        private ApiLibrary _library;

        public int GameCount
        {
            get
            {
                return _library.GameCount;
            }
        }

        public IEnumerable<Game> Games
        {
            get
            {
                foreach (var g in _library.Games)
                    yield return new Game(g);
            }
        }

        internal Library(ApiLibrary l)
        {
            _library = l;
        }
    }
}
