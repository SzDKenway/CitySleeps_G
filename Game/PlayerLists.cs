using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class PlayerLists
    {
        public List<Player> StartPack { get; set; }
        public List<Player> AliveList { get; set; }
        public List<Player> DeadList { get; set; }

        public PlayerLists()
        {
            StartPack = new List<Player>();
            AliveList = new List<Player>();
            DeadList = new List<Player>();
        }

        public PlayerLists(Shuffle s)
        {
            StartPack = new(s.pLists.StartPack);
            AliveList = new(s.pLists.AliveList);
            DeadList = new(s.pLists.DeadList);
        }
    }
}
