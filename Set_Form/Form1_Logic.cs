using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Game;

namespace Set_Form
{
    public class Form1_Logic
    {
        Random randomka; // egyszer hozzuk létre az osztályban
        public Form1_Logic()
        {
            randomka = new Random();
        }

        public bool PlayerNumSetting(int x)
        {
            Roles r = new Roles();


            if (x < 5)
            {
                MessageBox.Show("A szám amit megdtál túl KICSI!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (x > r.Karakterek.Length)
            {
                MessageBox.Show("A szám amit megdtál túl NAGY!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (MessageBox.Show("A szám amit beállítottál biztosan jó?", "Ellenőrzés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                return true;
            }
            return false;
        }

        public void CharacterAdder(Shuffle s, string name)
        {
            
            int index = randomka.Next(s.Roles.Length);
            Player player = new(name.ToUpper());
            player.IsActive = true;
            player.CharacterName = s.Roles[index];
            if (s.Roles.Length > 0)
            {
                string[] newRoles = new string[s.Roles.Length - 1];

                int j = 0;
                for (int i = 0; i < s.Roles.Length; i++)
                {
                    if (i != index)
                    {
                        newRoles[j] = s.Roles[i];
                        j++;
                    }
                }
                s.Roles = newRoles;
            }
            player.CharacterSpecifier();
            s.pLists.StartPack.Add(player);
            MessageBox.Show($"{player.PlayerName}\n( {player.CharacterName} )\n\nKépesség: {player.PowerString}", "Új játékos SIKERESEN hozzáadva!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public bool Checkname(Shuffle s, string name)
        {
            bool hiba;
            hiba = false;
            if (name.Length < 4)
            {
                MessageBox.Show("A megadott név túl rövid!\nLegalább 4 karakter hosszú legyen!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                hiba = true;
            }
            if (s.pLists.StartPack != null)
            {
                foreach (Player p in s.pLists.StartPack)
                {
                    if (name.ToUpper() == p.PlayerName.ToUpper())
                    {
                        MessageBox.Show("A megadott név MÁR SZEREPEL a listán", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        hiba = true;
                    }
                }
            }
            if (hiba)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
