namespace Set_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_CheckNumeric = new Button();
            label1 = new Label();
            dg_Karakter_Shuffler = new DataGridView();
            numeric_Player_Num = new NumericUpDown();
            label2 = new Label();
            tb_Player_Name = new TextBox();
            btn_AddCharacter = new Button();
            btn_ShowList = new Button();
            lbl_AddedPlayer = new Label();
            btn_Restart = new Button();
            btn_StartGame = new Button();
            lb_AllCharacterUsed = new ListBox();
            label3 = new Label();
            Player_NEVE = new DataGridViewTextBoxColumn();
            Karakter_Neve = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dg_Karakter_Shuffler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric_Player_Num).BeginInit();
            SuspendLayout();
            // 
            // btn_CheckNumeric
            // 
            btn_CheckNumeric.Location = new Point(22, 105);
            btn_CheckNumeric.Name = "btn_CheckNumeric";
            btn_CheckNumeric.Size = new Size(111, 43);
            btn_CheckNumeric.TabIndex = 0;
            btn_CheckNumeric.Text = "Check";
            btn_CheckNumeric.UseVisualStyleBackColor = true;
            btn_CheckNumeric.Click += CheckNumeric_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 1;
            label1.Text = "Játékosok Száma";
            // 
            // dg_Karakter_Shuffler
            // 
            dg_Karakter_Shuffler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_Karakter_Shuffler.Columns.AddRange(new DataGridViewColumn[] { Player_NEVE, Karakter_Neve });
            dg_Karakter_Shuffler.Location = new Point(265, 12);
            dg_Karakter_Shuffler.Name = "dg_Karakter_Shuffler";
            dg_Karakter_Shuffler.RowHeadersWidth = 51;
            dg_Karakter_Shuffler.Size = new Size(306, 875);
            dg_Karakter_Shuffler.TabIndex = 2;
            // 
            // numeric_Player_Num
            // 
            numeric_Player_Num.Location = new Point(22, 63);
            numeric_Player_Num.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numeric_Player_Num.Name = "numeric_Player_Num";
            numeric_Player_Num.Size = new Size(150, 27);
            numeric_Player_Num.TabIndex = 3;
            numeric_Player_Num.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 167);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 4;
            label2.Text = "Játékos Neve";
            // 
            // tb_Player_Name
            // 
            tb_Player_Name.Location = new Point(12, 203);
            tb_Player_Name.Name = "tb_Player_Name";
            tb_Player_Name.Size = new Size(125, 27);
            tb_Player_Name.TabIndex = 5;
            // 
            // btn_AddCharacter
            // 
            btn_AddCharacter.Location = new Point(12, 249);
            btn_AddCharacter.Name = "btn_AddCharacter";
            btn_AddCharacter.Size = new Size(168, 57);
            btn_AddCharacter.TabIndex = 7;
            btn_AddCharacter.Text = "Adj hozzá karaktert";
            btn_AddCharacter.UseVisualStyleBackColor = true;
            btn_AddCharacter.Click += AddCharacter_button_Click;
            // 
            // btn_ShowList
            // 
            btn_ShowList.Location = new Point(3, 327);
            btn_ShowList.Name = "btn_ShowList";
            btn_ShowList.Size = new Size(222, 51);
            btn_ShowList.TabIndex = 8;
            btn_ShowList.Text = "Listázás";
            btn_ShowList.UseVisualStyleBackColor = true;
            btn_ShowList.Click += ShowList_Button_Click;
            // 
            // lbl_AddedPlayer
            // 
            lbl_AddedPlayer.AutoSize = true;
            lbl_AddedPlayer.Location = new Point(22, 908);
            lbl_AddedPlayer.Name = "lbl_AddedPlayer";
            lbl_AddedPlayer.Size = new Size(55, 20);
            lbl_AddedPlayer.TabIndex = 9;
            lbl_AddedPlayer.Text = "Semmi";
            // 
            // btn_Restart
            // 
            btn_Restart.Location = new Point(49, 457);
            btn_Restart.Name = "btn_Restart";
            btn_Restart.Size = new Size(94, 29);
            btn_Restart.TabIndex = 10;
            btn_Restart.Text = "Restart";
            btn_Restart.UseVisualStyleBackColor = true;
            btn_Restart.Click += btn_Restart_Click;
            // 
            // btn_StartGame
            // 
            btn_StartGame.Location = new Point(46, 384);
            btn_StartGame.Name = "btn_StartGame";
            btn_StartGame.Size = new Size(134, 48);
            btn_StartGame.TabIndex = 11;
            btn_StartGame.Text = "Játék kezdés";
            btn_StartGame.UseVisualStyleBackColor = true;
            btn_StartGame.Click += btn_StartGame_Click;
            // 
            // lb_AllCharacterUsed
            // 
            lb_AllCharacterUsed.FormattingEnabled = true;
            lb_AllCharacterUsed.Location = new Point(12, 583);
            lb_AllCharacterUsed.Name = "lb_AllCharacterUsed";
            lb_AllCharacterUsed.Size = new Size(222, 304);
            lb_AllCharacterUsed.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 544);
            label3.Name = "label3";
            label3.Size = new Size(206, 20);
            label3.TabIndex = 13;
            label3.Text = "Összes játékban lévő karakter:";
            // 
            // Player_NEVE
            // 
            Player_NEVE.HeaderText = "Játékos NEVE";
            Player_NEVE.MinimumWidth = 6;
            Player_NEVE.Name = "Player_NEVE";
            Player_NEVE.Width = 125;
            // 
            // Karakter_Neve
            // 
            Karakter_Neve.HeaderText = "KARAKTER";
            Karakter_Neve.MinimumWidth = 6;
            Karakter_Neve.Name = "Karakter_Neve";
            Karakter_Neve.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 970);
            Controls.Add(label3);
            Controls.Add(lb_AllCharacterUsed);
            Controls.Add(btn_StartGame);
            Controls.Add(btn_Restart);
            Controls.Add(lbl_AddedPlayer);
            Controls.Add(btn_ShowList);
            Controls.Add(btn_AddCharacter);
            Controls.Add(tb_Player_Name);
            Controls.Add(label2);
            Controls.Add(numeric_Player_Num);
            Controls.Add(dg_Karakter_Shuffler);
            Controls.Add(label1);
            Controls.Add(btn_CheckNumeric);
            Name = "Form1";
            Text = "Játékosok Felvétele";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dg_Karakter_Shuffler).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric_Player_Num).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_CheckNumeric;
        private Label label1;
        private DataGridView dg_Karakter_Shuffler;
        private NumericUpDown numeric_Player_Num;
        private Label label2;
        private TextBox tb_Player_Name;
        private Button btn_AddCharacter;
        private Button btn_ShowList;
        private Label lbl_AddedPlayer;
        private Button btn_Restart;
        private Button btn_StartGame;
        private ListBox lb_AllCharacterUsed;
        private Label label3;
        private DataGridViewTextBoxColumn Player_NEVE;
        private DataGridViewTextBoxColumn Karakter_Neve;
    }
}
