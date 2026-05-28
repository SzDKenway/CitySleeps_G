namespace Set_Form
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_NextRound = new Button();
            label1 = new Label();
            tb_PlayerRound = new TextBox();
            lbl_Kepesseg = new Label();
            lbl_nap_ej = new Label();
            listB_AllAlivePlayer = new ListBox();
            listB_ChosenPlayer = new ListBox();
            label2 = new Label();
            tb_GyilkosCounter = new TextBox();
            d_DropDownL = new DomainUpDown();
            lbl_Charactername = new Label();
            dg_AliveLf2 = new DataGridView();
            PlayerName = new DataGridViewTextBoxColumn();
            PlayerHP = new DataGridViewTextBoxColumn();
            IsNightAC = new DataGridViewTextBoxColumn();
            BeenPlayedC = new DataGridViewTextBoxColumn();
            DeniedC = new DataGridViewTextBoxColumn();
            cb_IsGirlNoticed = new CheckBox();
            btn_Skip = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dg_AliveLf2).BeginInit();
            SuspendLayout();
            // 
            // btn_NextRound
            // 
            btn_NextRound.Location = new Point(192, 358);
            btn_NextRound.Name = "btn_NextRound";
            btn_NextRound.Size = new Size(166, 81);
            btn_NextRound.TabIndex = 0;
            btn_NextRound.Text = "Következő";
            btn_NextRound.UseVisualStyleBackColor = true;
            btn_NextRound.Click += btn_NextRound_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 1;
            label1.Text = "Játékos köre:";
            // 
            // tb_PlayerRound
            // 
            tb_PlayerRound.Location = new Point(111, 55);
            tb_PlayerRound.Name = "tb_PlayerRound";
            tb_PlayerRound.Size = new Size(125, 27);
            tb_PlayerRound.TabIndex = 2;
            // 
            // lbl_Kepesseg
            // 
            lbl_Kepesseg.AutoSize = true;
            lbl_Kepesseg.Location = new Point(225, 15);
            lbl_Kepesseg.Name = "lbl_Kepesseg";
            lbl_Kepesseg.Size = new Size(50, 20);
            lbl_Kepesseg.TabIndex = 3;
            lbl_Kepesseg.Text = "label2";
            // 
            // lbl_nap_ej
            // 
            lbl_nap_ej.AutoSize = true;
            lbl_nap_ej.Location = new Point(25, 15);
            lbl_nap_ej.Name = "lbl_nap_ej";
            lbl_nap_ej.Size = new Size(57, 20);
            lbl_nap_ej.TabIndex = 4;
            lbl_nap_ej.Text = "Éjszaka";
            // 
            // listB_AllAlivePlayer
            // 
            listB_AllAlivePlayer.FormattingEnabled = true;
            listB_AllAlivePlayer.Location = new Point(12, 186);
            listB_AllAlivePlayer.Name = "listB_AllAlivePlayer";
            listB_AllAlivePlayer.Size = new Size(150, 284);
            listB_AllAlivePlayer.TabIndex = 5;
            listB_AllAlivePlayer.MouseDoubleClick += listB_AllAlivePlayer_MouseDoubleClick;
            // 
            // listB_ChosenPlayer
            // 
            listB_ChosenPlayer.FormattingEnabled = true;
            listB_ChosenPlayer.Location = new Point(192, 186);
            listB_ChosenPlayer.Name = "listB_ChosenPlayer";
            listB_ChosenPlayer.Size = new Size(150, 84);
            listB_ChosenPlayer.TabIndex = 6;
            listB_ChosenPlayer.MouseDoubleClick += listB_ChosenPlayer_MouseDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 102);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 7;
            label2.Text = "gyilkosok száma:";
            // 
            // tb_GyilkosCounter
            // 
            tb_GyilkosCounter.Location = new Point(150, 102);
            tb_GyilkosCounter.Name = "tb_GyilkosCounter";
            tb_GyilkosCounter.Size = new Size(125, 27);
            tb_GyilkosCounter.TabIndex = 8;
            // 
            // d_DropDownL
            // 
            d_DropDownL.Location = new Point(192, 308);
            d_DropDownL.Name = "d_DropDownL";
            d_DropDownL.Size = new Size(150, 27);
            d_DropDownL.TabIndex = 9;
            // 
            // lbl_Charactername
            // 
            lbl_Charactername.AutoSize = true;
            lbl_Charactername.Location = new Point(254, 58);
            lbl_Charactername.Name = "lbl_Charactername";
            lbl_Charactername.Size = new Size(50, 20);
            lbl_Charactername.TabIndex = 10;
            lbl_Charactername.Text = "label3";
            // 
            // dg_AliveLf2
            // 
            dg_AliveLf2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_AliveLf2.Columns.AddRange(new DataGridViewColumn[] { PlayerName, PlayerHP, IsNightAC, BeenPlayedC, DeniedC });
            dg_AliveLf2.Location = new Point(401, 58);
            dg_AliveLf2.Name = "dg_AliveLf2";
            dg_AliveLf2.RowHeadersWidth = 51;
            dg_AliveLf2.Size = new Size(876, 338);
            dg_AliveLf2.TabIndex = 11;
            // 
            // PlayerName
            // 
            PlayerName.HeaderText = "Játékos";
            PlayerName.MinimumWidth = 6;
            PlayerName.Name = "PlayerName";
            PlayerName.Width = 125;
            // 
            // PlayerHP
            // 
            PlayerHP.HeaderText = "HP";
            PlayerHP.MinimumWidth = 6;
            PlayerHP.Name = "PlayerHP";
            PlayerHP.Width = 125;
            // 
            // IsNightAC
            // 
            IsNightAC.HeaderText = "NightActive?";
            IsNightAC.MinimumWidth = 6;
            IsNightAC.Name = "IsNightAC";
            IsNightAC.Width = 125;
            // 
            // BeenPlayedC
            // 
            BeenPlayedC.HeaderText = "IsShowed";
            BeenPlayedC.MinimumWidth = 6;
            BeenPlayedC.Name = "BeenPlayedC";
            BeenPlayedC.Width = 125;
            // 
            // DeniedC
            // 
            DeniedC.HeaderText = "DeniedP";
            DeniedC.MinimumWidth = 6;
            DeniedC.Name = "DeniedC";
            DeniedC.Width = 125;
            // 
            // cb_IsGirlNoticed
            // 
            cb_IsGirlNoticed.AutoSize = true;
            cb_IsGirlNoticed.Location = new Point(176, 457);
            cb_IsGirlNoticed.Name = "cb_IsGirlNoticed";
            cb_IsGirlNoticed.Size = new Size(273, 24);
            cb_IsGirlNoticed.TabIndex = 12;
            cb_IsGirlNoticed.Text = "Észre vették a kislány? (pipa ha igen)";
            cb_IsGirlNoticed.UseVisualStyleBackColor = true;
            cb_IsGirlNoticed.CheckedChanged += IsGirlNoticed_CheckedChanged;
            // 
            // btn_Skip
            // 
            btn_Skip.Location = new Point(518, 426);
            btn_Skip.Name = "btn_Skip";
            btn_Skip.Size = new Size(94, 29);
            btn_Skip.TabIndex = 13;
            btn_Skip.Text = "Skip";
            btn_Skip.UseVisualStyleBackColor = true;
            btn_Skip.Click += btn_Skip_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(518, 481);
            label3.Name = "label3";
            label3.Size = new Size(403, 20);
            label3.TabIndex = 14;
            label3.Text = "Akkor használd: Hogyha senkit se akarnak nappal kiszavazni";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 147);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 15;
            label4.Text = "Összes játékos:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(192, 147);
            label5.Name = "label5";
            label5.Size = new Size(140, 20);
            label5.TabIndex = 16;
            label5.Text = "Kiválasztott játékos:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 510);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_Skip);
            Controls.Add(cb_IsGirlNoticed);
            Controls.Add(dg_AliveLf2);
            Controls.Add(lbl_Charactername);
            Controls.Add(d_DropDownL);
            Controls.Add(tb_GyilkosCounter);
            Controls.Add(label2);
            Controls.Add(listB_ChosenPlayer);
            Controls.Add(listB_AllAlivePlayer);
            Controls.Add(lbl_nap_ej);
            Controls.Add(lbl_Kepesseg);
            Controls.Add(tb_PlayerRound);
            Controls.Add(label1);
            Controls.Add(btn_NextRound);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dg_AliveLf2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_NextRound;
        private Label label1;
        private TextBox tb_PlayerRound;
        private Label lbl_Kepesseg;
        private Label lbl_nap_ej;
        private ListBox listB_AllAlivePlayer;
        private ListBox listB_ChosenPlayer;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox tb_GyilkosCounter;
        private DomainUpDown d_DropDownL;
        private Label lbl_Charactername;
        private DataGridView dg_AliveLf2;
        private CheckBox cb_IsGirlNoticed;
        private Button btn_Skip;
        private DataGridViewTextBoxColumn PlayerName;
        private DataGridViewTextBoxColumn PlayerHP;
        private DataGridViewTextBoxColumn IsNightAC;
        private DataGridViewTextBoxColumn BeenPlayedC;
        private DataGridViewTextBoxColumn DeniedC;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}