using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Cycle
    {
        public Shuffle CycleInfo { get; set; }
        public Player PlayingPlayer { get; set; }
        Roles RoleOrder;
        public int NewDead { get; set; }
        public Cycle(Shuffle s)
        {
            NewDead = 0;
            CycleInfo = new(s);
            CycleInfo.pLists.AliveList = new(CycleInfo.pLists.StartPack);
            RoleOrder = new();
        }

        /// <summary>
        /// Chooses a playable PLAYER during the nightphase
        /// </summary>
        /// <returns>Returns a PLAYER who is playable during the night phase</returns>
        public Player PlayingP()
        {
            for (int i = 0; i < RoleOrder.Karakterek.Length; i++)
            {
                for (int j = 0; j < CycleInfo.pLists.StartPack.Count; j++)
                {
                    if (CycleInfo.pLists.StartPack[j].CharacterName == RoleOrder.Karakterek[i] && CycleInfo.pLists.StartPack[j].IsShowed == false && CycleInfo.pLists.StartPack[j].IsNightActive)
                    {
                        return CycleInfo.pLists.StartPack[j];
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Set played player to used during the NIGHT phase
        /// </summary>
        //public void PlayerUsed()
        //{
        //    if (PlayingPlayer != null)
        //    {
        //        PlayingPlayer.BeenPlayed = true;
        //    }
        //}

        /// <summary>
        /// If kislany is in the Starterpack
        /// </summary>
        /// <returns>If she is included its TRUE</returns>
        public bool IsGirlActive()
        {
            foreach (Player p in CycleInfo.pLists.StartPack)
            {
                if (p.CharacterName == "Kislany")
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Restores Logan's HP to 100
        /// </summary>
        public void LoganRestoreHP()
        {
            foreach (Player p in CycleInfo.pLists.AliveList)
            {
                if (p.CharacterName == "Logan")
                {
                    p.HP = 100;
                }
            }
        }

        /// <summary>
        /// Girl's hp is reduced to 0.
        /// </summary>
        public void KillGirl()
        {
            foreach (Player p in CycleInfo.pLists.AliveList)
            {
                if (p.CharacterName == "Kislany")
                {
                    p.HP = 0;
                }
                if (p.CharacterName == "John Wick")
                {
                    p.IsNightActive = true;
                }
            }
        }

        /// <summary>
        /// Night phase: - PlayingPlayer CURRENT player's round
        /// </summary>
        /// <param name="victim">PlayingPlayer's victim during the night</param>
        public void Night(Player victim)
        {
            PlayingPlayer = PlayingP();
            if (!PlayingPlayer.DeniedP)
            {
                Night_CharacterPowerSwitch(PlayingPlayer, victim);
            }
        }


        /// <summary>
        /// Checks Alive-list for playable character during the night phase
        /// </summary>
        /// <returns></returns>
        public bool IsNight()
        {
            if (PlayingP() != null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Day PHASE: Victim gets ruled and executed
        /// </summary>
        /// <param name="ruler">Who rules out the victim</param>
        /// <param name="victim">victim</param>
        public void Day(Player ruler, Player victim)
        {
            victim.HP = 0;
            RefreshL();
            ResetNightStat();
        }

        /// <summary>
        /// Refreshes the Alive and Dead lists
        /// </summary>
        public void RefreshL()
        {
            for (int i = CycleInfo.pLists.AliveList.Count - 1; i >= 0; i--)
            {
                Player p = CycleInfo.pLists.AliveList[i];
                if (p.HP <= 0)
                {
                    CycleInfo.pLists.AliveList.RemoveAt(i);
                    CycleInfo.pLists.DeadList.Add(p);
                    p.IsDead = true;
                    NewDead++;
                }
            }
        }

        /// <summary>
        /// Selyemfiu from StartPack damages those who are on his victimlist
        /// </summary>
        public void SelyemInfect()
        {
            foreach (Player p in CycleInfo.pLists.StartPack)
            {
                if (p.CharacterName == "Selyemfiu")
                {
                    foreach (Player infected in p.VictimList)
                    {
                        infected.HP -= 50;
                    }
                }
            }
        }

        /// <summary>
        /// resets DeniedP, IsShowed bools for everyone on StartPack
        /// </summary>
        public void ResetNightStat()
        {
            foreach (Player p in CycleInfo.pLists.StartPack)
            {
                p.IsShowed = false;
                p.DeniedP = false;

            }
        }

        /// <summary>
        /// Checks if Logan is denied
        /// </summary>
        /// <returns>true if Logan is denied</returns>
        public bool IsLoganDenied()
        {
            foreach (Player p in CycleInfo.pLists.AliveList)
            {
                if (p.CharacterName == "Logan" && p.DeniedP)
                {
                    return true;
                }   
            }
            return false;
        }

        /// <summary>
        /// Put recently dead in a string so it can be showed ina  messagebox on form
        /// </summary>
        /// <returns>String with recent DEAD players name or "" if its empty</returns>
        public string ShowDead()
        {
            List<string> list = new List<string>();
            if (NewDead != 0)
            {
                for (int i = CycleInfo.pLists.DeadList.Count - NewDead; i < CycleInfo.pLists.DeadList.Count; i++)
                {
                    list.Add(CycleInfo.pLists.DeadList[i].PlayerName);
                }
                NewDead = 0;
                return string.Join(", ", list);
            }
            return "";
        }   

        /// <summary>
        /// Switch for chosing a specific method for skills
        /// </summary>
        /// <param name="powerUser">Playing Player</param>
        /// <param name="victim">Victim of the playing player</param>
        public void Night_CharacterPowerSwitch(Player powerUser, Player victim)
        {
            switch (powerUser.CharacterName)
            {
                case "Orvos":
                    Orvos_P(victim);
                    break;
                case "Gyilkos":
                    Gyilkos_P(victim);
                    break;
                case "Keresztapa":
                    Kereszt_P(victim);
                    break;
                case "Felugyelo":
                    Felugyelo_P(victim);
                    break;
                case "Csonkito":
                    Csonkito_P(victim);
                    break;
                case "Selyemfiu":
                    SelyemF_P(victim);
                    break;
                case "John Wick":
                    JohnWick_P(victim);
                    break;
                case "Prosti":
                    Prosti_P(victim);
                    break;

            }
        }


        /// <summary>
        /// Count the Killers
        /// </summary>
        /// <returns>Number of Gyilkosok</returns>
        public int GyilkosCounter()
        {
            int gyilkosok = 0;
            foreach (Player p in CycleInfo.pLists.AliveList)
            {
                if (p.CharacterName == "Gyilkos" || p.CharacterName == "Keresztapa")
                {
                    gyilkosok++;
                }
            }

            return gyilkosok;
        }

        /// <summary>
        /// Gets the victim of the Selyemfiús list
        /// </summary>
        /// <param name="victimP">target to remove from the list</param>
        public void FarajoSpec(Player victimP)
        {
            foreach (Player p in CycleInfo.pLists.StartPack)
            {
                if (p.CharacterName == "Selyemfiu")
                {
                    for (int i = p.VictimList.Count - 1; i >= 0; i--)
                    {
                        if (victimP.CharacterName == p.VictimList[i].CharacterName)
                        {
                            p.VictimList.RemoveAt(i);
                        }
                    }
                }
            }
        }
// ------------------------------Szerep képességek------------------------------
        public void Kereszt_P(Player victimP)
        {
            victimP.HP -= 75;
        }

        public void Gyilkos_P(Player victimP)
        {
            victimP.HP -= 50;
        }

        public void Felugyelo_P(Player victimP)
        {
            if (victimP.CharacterName == "Gyilkos")
            {
                victimP.HP = 0;
            }
            else if(victimP.CharacterName == "Keresztapa")
            {
                victimP.HP -= 50;
            }
            victimP.DeniedP = true;
            
        }

        public void Csonkito_P(Player victimP)
        {
            victimP.DeniedP = true;
        }

        public void Orvos_P(Player victimP)
        {
            victimP.HP = 100;
        }

        public void SelyemF_P(Player victimP)
        {
            foreach (Player SelyemF in CycleInfo.pLists.StartPack)
            {
                if (SelyemF.CharacterName == "Selyemfiu")
                {
                    SelyemF.VictimList.Add(victimP);
                }
            }
        }

        public void Farajo_P(Player victimP)
        {
            if (victimP.HP < 100)
            {
                victimP.HP = 100;
            }
            FarajoSpec(victimP);
        }

        public void JohnWick_P(Player victimP)
        {
            victimP.HP = 0;
        }

        public void Prosti_P(Player victimP)
        {
            FarajoSpec(victimP);
        }
    }
}
