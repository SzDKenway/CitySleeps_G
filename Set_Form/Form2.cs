    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Game;

    namespace Set_Form
    {
        public partial class Form2 : Form
        {
            Cycle c;
            /// <summary>
            /// Ha a listák valahol üresek akkor hiba van és message jön
            /// </summary>
            bool hiba;
            public Form2(Shuffle s)
            {
                hiba = false;
                InitializeComponent();
                d_DropDownL.Enabled = false;
                btn_Skip.Enabled = false;
                c = new(s);
                c.PlayingPlayer = c.PlayingP();
                TextRefresher();
                s.pLists.AliveList = new(s.pLists.StartPack); // Alive lista feltöltése Startpackból
                FillAliveList();
                if (!c.IsGirlActive())
                {
                    cb_IsGirlNoticed.Visible = false;
                }
                KillerRound();
                MessageBox.Show("Keresd vissza a GYILKOSt és a KERESZTAPÁt és csak őket keltsd fel hogy tudjanak egymásról. Más nem kelhet fel.", "Keltsd fel a gyilkosokat.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

            /// <summary>
            /// if c.PlayingPlayer is not IsNightActive or not yet showed but isdead then a message box appear and then it skips to the next player.
            /// </summary>
            public void PlayerPCurrently()
            {
                if (c.PlayingPlayer != null)
                {
                    if (c.PlayingPlayer.IsShowed == false)
                    {
                        if (c.PlayingPlayer.IsDead)
                        {
                            MessageBox.Show($"[{c.PlayingPlayer.CharacterName}]\nkeljen fel... (tarts szünetet) Aludjon visza.", "Olvasd fel...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            c.PlayingPlayer.IsShowed = true;
                            TextRefresher();
                            FillAliveList();
                        }
                    
                    }
                }
           
            
            }

        /// <summary>
        /// Modifies nap/ej text, gyilkoscounter, Playing player's text, and the datagrid, REDEFIES c.PlayingPlayer (!!!)
        /// </summary>
        public void TextRefresher()
            {
                c.PlayingPlayer = c.PlayingP();
                lbl_nap_ej.Text = IsNightString(c);
                PlayingPString();
                tb_GyilkosCounter.Text = c.GyilkosCounter().ToString();
                DataGridRefresher();
            }

            /// <summary>
            /// Refreshes AliveList datagrid
            /// </summary>
            public void DataGridRefresher()
            {
                dg_AliveLf2.Rows.Clear();
                foreach (Player p in c.CycleInfo.pLists.AliveList)
                {
                    dg_AliveLf2.Rows.Add(p.PlayerName, p.HP, p.IsNightActive, p.IsShowed, p.DeniedP); // további oszlopok adatit ITT add hozzá
                }
            }

            public void Cycling(Cycle c)
            {
                hiba = false;
                if (c.GyilkosCounter() < c.CycleInfo.pLists.AliveList.Count && c.GyilkosCounter() != 0) // end game if
                {
                    if (c.IsNight()) // este
                    {
                        d_DropDownL.Enabled = false;
                        if (listB_ChosenPlayer.SelectedItem != null)
                        {
                            foreach (Player p in listB_ChosenPlayer.SelectedItems)
                            {
                                c.Night(p);   
                            }
                            if (!c.IsLoganDenied())
                            {
                                c.LoganRestoreHP();
                            }
                            c.PlayingPlayer.IsShowed = true;
                        }
                        else
                        {
                            MessageBox.Show("A kiválasztott játékos lista ÜRES", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            hiba = true;
                        }
                    
                    }
                    else // nappal
                    {
                        if (d_DropDownL.SelectedItem != null && listB_ChosenPlayer.SelectedItem != null)
                        {
                        
                            Player ruler = (Player)d_DropDownL.SelectedItem;
                            Player victim = (Player)listB_ChosenPlayer.SelectedItem;
                            if (ruler.PlayerName == victim.PlayerName)  // <-- hasonlítós HIBA
                            {
                                MessageBox.Show("A kiválasztott játékos és a felterjesztő játékos UGYANAZ.", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                hiba = true;
                            }
                            else
                            {
                                c.Day(ruler, victim);
                                if (victim.CharacterName == "Alien")
                                {
                                    ruler.HP = 0;
                                    MessageBox.Show($"A felterjesztő játékos Alien volt\n{ruler.PlayerName} meghalt.", "INFÓ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show($"\nFelterjesztő:{ruler.PlayerName}\nkivégzett:{victim.PlayerName}.", "INFÓ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                } 
                            }
                        
                        }
                        else
                        {
                            MessageBox.Show("A kiválasztott játékos lista vagy a dropdown menü ÜRES", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            hiba = true;
                        }
                    }
                    c.PlayingPlayer = c.PlayingP();

                }
                else if (c.GyilkosCounter() > c.CycleInfo.pLists.AliveList.Count)
                {
                    MessageBox.Show("Gyilkosok nyertek.", "JÁTÉK VÉGE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (c.GyilkosCounter() == 0)
                {
                    MessageBox.Show("Nép nyert.", "JÁTÉK VÉGE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            /// <summary>
            /// Messagebox for recently died player
            /// </summary>
            public void RecentlyDiedShow()
            {
                if (c.ShowDead() == "")
                {
                    MessageBox.Show("Nincsenek új halottak", "Friss Halottak", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(c.ShowDead(), "Friss Halottak", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            /// <summary>
            /// During the day, show the dropdown menu who ruled out the victim
            /// </summary>
            public void DropDownFilter()
            {
                //c.RefreshL();
                d_DropDownL.Enabled = true;
                if (listB_ChosenPlayer.SelectedItem != null)
                {
                    foreach (Player p in c.CycleInfo.pLists.AliveList)
                    {
                        if (listB_AllAlivePlayer.Text != p.PlayerName)
                        {
                            d_DropDownL.Items.Add(p);
                        }
                    }
                }

            }

            /// <summary>
            /// Fills/REFRESHES Alive ListBox except for the currently playing Player 
            /// </summary>
            public void FillAliveList()
            {
                listB_AllAlivePlayer.Items.Clear();
                foreach (Player p in c.CycleInfo.pLists.AliveList)
                {
                    if (p.CharacterName == "Orvos")
                    {
                        listB_AllAlivePlayer.Items.Add(p);

                    }
                    else
                    {
                        if (tb_PlayerRound.Text != p.PlayerName)
                        {
                            listB_AllAlivePlayer.Items.Add(p);
                        }
                    }

                }
            }

            /// <summary>
            /// Writes/REFRESHES string whether its night or day phase
            /// </summary>
            /// <param name="c"></param>
            /// <returns></returns>
            public string IsNightString(Cycle c)
            {
                if (!c.IsNight())
                {
                
                    btn_Skip.Enabled = true;
                    return "Nappal";
                }
                btn_Skip.Enabled = false;
                return "Éjszaka";

            }

            /// <summary>
            /// REFRESHES the tb_PlayerRound textbox's string, Charactername label
            /// </summary>
            public void PlayingPString()
            {
                if (c.IsNight())
                {
                    tb_PlayerRound.Text = c.PlayingPlayer.PlayerName;
                    lbl_Charactername.Text = c.PlayingPlayer.CharacterName;
                    lbl_Kepesseg.Text = c.PlayingPlayer.PowerString;
                }
                else
                {
                    tb_PlayerRound.Text = "Senki";
                    lbl_Charactername.Text = "nincs karakter kör";
                    lbl_Kepesseg.Text = "nincs képesség";
                    c.RefreshL();
                    DropDownFilter();
                }

            }

            /// <summary>
            /// Enables checkbox to click if LilGirl is on aliveList and its Gyilkos/Keresztapa turn.
            /// </summary>
            public void KillerRound()
            {
                if (c.PlayingPlayer != null)
                {
                    if (c.PlayingPlayer.CharacterName != null)
                    {
                        foreach (Player player in c.CycleInfo.pLists.AliveList)
                        {
                            if (player.CharacterName == "Kislany" && player.HP >= 1)
                            {
                                if (c.PlayingPlayer.CharacterName == "Gyilkos" || c.PlayingPlayer.CharacterName == "Keresztapa")
                                {
                                    cb_IsGirlNoticed.Enabled = true;
                                }
                                else
                                {
                                    cb_IsGirlNoticed.Enabled = false;
                                }
                            }
                        }

                    }
                }
            }

            // --------------------------------------------------------------GOMBOK--------------------------------------------------------------
            private void NXTButtonFunction()
            {
                Cycling(c);
                if (!hiba)
                {
                    TextRefresher();
                    FillAliveList();
                    if (!c.IsNight())
                    {
                        c.SelyemInfect();
                        c.RefreshL();
                        if (c.NewDead > 0)
                        {
                            MessageBox.Show(c.ShowDead(), "Legútobbi éjszaka meghalt játékosok", MessageBoxButtons.OK);
                        }
                        TextRefresher();
                        FillAliveList();
                        DropDownFilter();
                    }
                }
                listB_ChosenPlayer.Items.Clear();
                KillerRound();
                while (c.PlayingPlayer != null && c.PlayingPlayer.IsDead)
                {
                    PlayerPCurrently();
                }
            }

            private void listB_AllAlivePlayer_MouseDoubleClick(object sender, MouseEventArgs e)
            {
                if (listB_AllAlivePlayer.SelectedItem == null)
                    return;
                listB_ChosenPlayer.Items.Add(listB_AllAlivePlayer.SelectedItem);
                listB_ChosenPlayer.SelectedIndex = 0;
            }

            private void listB_ChosenPlayer_MouseDoubleClick(object sender, MouseEventArgs e)
            {
                listB_ChosenPlayer.Items.Clear();
            }

            private void btn_NextRound_Click(object sender, EventArgs e)
            {
                NXTButtonFunction();
            }

            private void IsGirlNoticed_CheckedChanged(object sender, EventArgs e)
            {
                if (c.IsNight())
                {
                    if (MessageBox.Show("Biztosan észre vették a kislányt?", "KÉRDÉS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        c.KillGirl();
                        cb_IsGirlNoticed.Enabled = false;
                        DataGridRefresher();
                        FillAliveList();
                    }
                }
                else
                {
                    MessageBox.Show("Nappal nem lehet ezt megjelölni.", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btn_Skip_Click(object sender, EventArgs e)
            {
                c.ResetNightStat();
                c.PlayingPlayer = c.PlayingP();
                TextRefresher();
                FillAliveList();
                while (c.PlayingPlayer != null && c.PlayingPlayer.IsDead)
                {
                    PlayerPCurrently();
                }
        }
        }
    }
