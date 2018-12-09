using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESC_Registration_Application
{
    class Entrant : IComparable
    {
        public Player _player { get; private set; }
        public List<bool> _entries;

        public Entrant(Player player, List<bool> game_entries)
        {
            _player = player;
            _entries = game_entries;
        }

        public int CompareTo(object objEntrant)
        {
            Entrant entrant2 = (Entrant)objEntrant;

            return -1 * _player.game_rating.CompareTo(entrant2._player.game_rating);
        }

        public override bool Equals(object obj)
        {
            Entrant objEntrant = (Entrant)obj;

            return _player.Equals(objEntrant._player);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
