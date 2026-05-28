using System.Collections.Generic;
using Game;

namespace Set_Form
{
    public partial class Form1 : Form
    {
        private int PlayerAddedCounter = 0;
        Shuffle s;
        Random randomka; // egyszer hozzuk létre az osztályban
        Form1_Logic fL1;
        Form2 fL2;
        public Form1()
        {
            fL1 = new Form1_Logic();
            InitializeComponent();
            btn_ShowList.Enabled = false;
            btn_AddCharacter.Enabled = false;
            lbl_AddedPlayer.Visible = false;
            btn_StartGame.Enabled = false;
            randomka = new Random();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Elsõként állitsd be a játékosok számát majd nyomj a CHECK gombra!", "TIPP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void FillAllCharListB(int x)
        {
            Roles r = new Roles();
            for (int i = 0; i < x; i++)
            {
                lb_AllCharacterUsed.Items.Add(r.Karakterek[i]);
            }
        }
        private void CheckNumeric_Click(object sender, EventArgs e)
        {
            if (fL1.PlayerNumSetting((int)numeric_Player_Num.Value) == true)
            {
                btn_CheckNumeric.Enabled = false;
                btn_AddCharacter.Enabled = true;
                FillAllCharListB((int)numeric_Player_Num.Value);
                s = new((int)numeric_Player_Num.Value);
                AddedPlayerTextManager();
            }
        }

        private void AddCharacter_button_Click(object sender, EventArgs e)
        {
            numeric_Player_Num.ReadOnly = true;
            btn_ShowList.Enabled = false;
            btn_CheckNumeric.Enabled = false;


            if (s.pLists.StartPack != null && s.pLists.StartPack.Count < (int)numeric_Player_Num.Value)
            {

                if (!fL1.Checkname(s, tb_Player_Name.Text))
                {
                    tb_Player_Name.Clear();
                }
                else
                {
                    lbl_AddedPlayer.Visible = false;
                    fL1.CharacterAdder(s, tb_Player_Name.Text);
                    tb_Player_Name.Clear();
                    PlayerAddedCounter++;
                    lbl_AddedPlayer.Visible = true;
                }
            }

            AddedPlayerTextManager();
        }

        private void ShowList_Button_Click(object sender, EventArgs e)
        {
            btn_StartGame.Enabled = true;
            dg_Karakter_Shuffler.Rows.Clear();
            foreach (Player p in s.pLists.StartPack)
            {
                int rowIndex = dg_Karakter_Shuffler.Rows.Add(p.PlayerName, p.CharacterName);

                if (p.CharacterName == "Gyilkos" || p.CharacterName == "Keresztapa")
                {
                    dg_Karakter_Shuffler.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                    dg_Karakter_Shuffler.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
        public void AddedPlayerTextManager()
        {
            if (s.pLists.StartPack.Count > 0 && PlayerAddedCounter < (int)numeric_Player_Num.Value)
            {
                lbl_AddedPlayer.Text = $"Hozzáadott játékosok száma: {PlayerAddedCounter}/{(int)numeric_Player_Num.Value}";
            }
            else if ((int)numeric_Player_Num.Value == PlayerAddedCounter)
            {
                lbl_AddedPlayer.Text = "Minden játékost hozzáadtál";
                btn_ShowList.Enabled = true;
                btn_AddCharacter.Enabled = false;
                MessageBox.Show("A bevitt játékosok száma elérte a megadott számú játékosokét.\n Most már tudsz majd listázni de ezt már csak TITKOSAN tedd!!!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                lbl_AddedPlayer.Text = "Semmise";
            }
        }
        private void btn_Restart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan újra szeretnéd kezdeni?", "KÉRDÉS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                s = null;
                PlayerAddedCounter = 0;
                numeric_Player_Num.Enabled = true;
                btn_CheckNumeric.Enabled = true;
                btn_ShowList.Enabled = false;
                btn_AddCharacter.Enabled = false;
                randomka = new Random();
                lbl_AddedPlayer.Visible = false;
                btn_StartGame.Enabled = false;
                dg_Karakter_Shuffler.Rows.Clear();
                numeric_Player_Num.Value = 5;
                tb_Player_Name.Clear();
                lb_AllCharacterUsed.Items.Clear();
            }
        }

        private void btn_StartGame_Click(object sender, EventArgs e)
        {
            fL2 = new(s);
            fL2.ShowDialog();
        }
    }
}
