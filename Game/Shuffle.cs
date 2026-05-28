using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Shuffle
    {
        public PlayerLists pLists { get; set; }
        public int All_Players_Num { get; set; }
        public string[] Roles { get; set; }
        public Shuffle(int x)
        {
            pLists = new PlayerLists();
            Roles r = new Roles();
            Roles = FillRoles(r.Karakterek, x);
            All_Players_Num = x;
        }

        public Shuffle(Shuffle otherS)
        {
            All_Players_Num = otherS.All_Players_Num;
            Roles = (string[])otherS.Roles.Clone();
            pLists = new(otherS);
        }

        /// <summary>
        /// Makes a LOCAL Roles[] to be able to track it better and made for cutting it later
        /// </summary>
        /// <param name="roles">Original list</param>
        /// <param name="x">Number of Players</param>
        /// <returns></returns>
        public string[] FillRoles(string[] roles, int x)
        {
            string[] list = new string[x];

            for (int i = 0; i < x; i++)
            {
                list[i] = roles[i];
            }
            return list;
        }

        // Give one citizen a role and delete that role from the local roles and put it on the Starterpack
        private Random rnd = new Random();
        /// <summary>
        /// Gives a role to a player and decrease the amount of roles to give
        /// </summary>
        /// <param name="p">chosen palyer to be given a role</param>
        /// <returns>Player with the random role</returns>
        public Player CharacterMaker(Player p)
        {
            int index = rnd.Next(Roles.Length);

            // szerep kiosztása
            p.CharacterName = Roles[index];

            // új tömb létrehozása
            string[] newRoles = new string[Roles.Length - 1];

            int j = 0;
            for (int i = 0; i < Roles.Length; i++)
            {
                if (i != index)
                {
                    newRoles[j] = Roles[i];
                    j++;
                }
            }

            Roles = newRoles; // itt módosul a property

            return p;
        }



    }
}
