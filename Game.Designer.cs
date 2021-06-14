
namespace Monsters_and_Demons
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.PctrMonster = new System.Windows.Forms.PictureBox();
            this.HunterStanding = new System.Windows.Forms.PictureBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnSpells = new System.Windows.Forms.Button();
            this.btnBackpack = new System.Windows.Forms.Button();
            this.btnRunAway = new System.Windows.Forms.Button();
            this.HunterAttacking = new System.Windows.Forms.PictureBox();
            this.TimerAttack = new System.Windows.Forms.Timer(this.components);
            this.PlayerHealthBar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnemyHealthBar = new System.Windows.Forms.PictureBox();
            this.panelNextBattle = new System.Windows.Forms.Panel();
            this.btnBottomWin = new System.Windows.Forms.Button();
            this.pctrNextBattle = new System.Windows.Forms.PictureBox();
            this.lblBattleCounter = new System.Windows.Forms.Label();
            this.lblBattleNumber = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pctrBattleLog = new System.Windows.Forms.PictureBox();
            this.panelDeath = new System.Windows.Forms.Panel();
            this.btnDeathTop = new System.Windows.Forms.Button();
            this.btnDeathBottom = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtboxBattleLog = new System.Windows.Forms.TextBox();
            this.lblGoldCoins = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PctrMonster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HunterStanding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HunterAttacking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHealthBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHealthBar)).BeginInit();
            this.panelNextBattle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrNextBattle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBattleLog)).BeginInit();
            this.panelDeath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PctrMonster
            // 
            this.PctrMonster.BackColor = System.Drawing.Color.Transparent;
            this.PctrMonster.Image = global::Monsters_and_Demons.Properties.Resources.GreenSlime;
            this.PctrMonster.Location = new System.Drawing.Point(500, 200);
            this.PctrMonster.Name = "PctrMonster";
            this.PctrMonster.Size = new System.Drawing.Size(38, 32);
            this.PctrMonster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PctrMonster.TabIndex = 0;
            this.PctrMonster.TabStop = false;
            // 
            // HunterStanding
            // 
            this.HunterStanding.BackColor = System.Drawing.Color.Transparent;
            this.HunterStanding.Image = global::Monsters_and_Demons.Properties.Resources.Hunter_Standing_animation1;
            this.HunterStanding.Location = new System.Drawing.Point(109, 173);
            this.HunterStanding.Name = "HunterStanding";
            this.HunterStanding.Size = new System.Drawing.Size(284, 243);
            this.HunterStanding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HunterStanding.TabIndex = 1;
            this.HunterStanding.TabStop = false;
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.Transparent;
            this.btnAttack.BackgroundImage = global::Monsters_and_Demons.Properties.Resources.bow1;
            this.btnAttack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAttack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAttack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttack.Location = new System.Drawing.Point(314, 359);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(100, 75);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnSpells
            // 
            this.btnSpells.BackColor = System.Drawing.Color.Transparent;
            this.btnSpells.BackgroundImage = global::Monsters_and_Demons.Properties.Resources.scroll1;
            this.btnSpells.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpells.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpells.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSpells.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSpells.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpells.Location = new System.Drawing.Point(123, 359);
            this.btnSpells.Name = "btnSpells";
            this.btnSpells.Size = new System.Drawing.Size(100, 75);
            this.btnSpells.TabIndex = 3;
            this.btnSpells.UseVisualStyleBackColor = false;
            // 
            // btnBackpack
            // 
            this.btnBackpack.BackColor = System.Drawing.Color.Transparent;
            this.btnBackpack.BackgroundImage = global::Monsters_and_Demons.Properties.Resources.backpack1;
            this.btnBackpack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackpack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackpack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBackpack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBackpack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackpack.Location = new System.Drawing.Point(218, 359);
            this.btnBackpack.Name = "btnBackpack";
            this.btnBackpack.Size = new System.Drawing.Size(100, 75);
            this.btnBackpack.TabIndex = 4;
            this.btnBackpack.UseVisualStyleBackColor = false;
            // 
            // btnRunAway
            // 
            this.btnRunAway.BackColor = System.Drawing.Color.Transparent;
            this.btnRunAway.BackgroundImage = global::Monsters_and_Demons.Properties.Resources.map1;
            this.btnRunAway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRunAway.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRunAway.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRunAway.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRunAway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunAway.ForeColor = System.Drawing.Color.Black;
            this.btnRunAway.Location = new System.Drawing.Point(23, 359);
            this.btnRunAway.Name = "btnRunAway";
            this.btnRunAway.Size = new System.Drawing.Size(100, 75);
            this.btnRunAway.TabIndex = 5;
            this.btnRunAway.UseVisualStyleBackColor = false;
            this.btnRunAway.Click += new System.EventHandler(this.btnRunAway_Click);
            // 
            // HunterAttacking
            // 
            this.HunterAttacking.BackColor = System.Drawing.Color.Transparent;
            this.HunterAttacking.Image = global::Monsters_and_Demons.Properties.Resources.hunter_animation_attack1;
            this.HunterAttacking.Location = new System.Drawing.Point(109, 173);
            this.HunterAttacking.Name = "HunterAttacking";
            this.HunterAttacking.Size = new System.Drawing.Size(284, 243);
            this.HunterAttacking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HunterAttacking.TabIndex = 6;
            this.HunterAttacking.TabStop = false;
            // 
            // TimerAttack
            // 
            this.TimerAttack.Interval = 1000;
            this.TimerAttack.Tick += new System.EventHandler(this.TimerAttack_Tick);
            // 
            // PlayerHealthBar
            // 
            this.PlayerHealthBar.BackColor = System.Drawing.Color.Black;
            this.PlayerHealthBar.BackgroundImage = global::Monsters_and_Demons.Properties.Resources.character_hp_bar_bg_RED;
            this.PlayerHealthBar.Image = global::Monsters_and_Demons.Properties.Resources.character_hp_bar_frame1;
            this.PlayerHealthBar.Location = new System.Drawing.Point(185, 173);
            this.PlayerHealthBar.Name = "PlayerHealthBar";
            this.PlayerHealthBar.Size = new System.Drawing.Size(100, 15);
            this.PlayerHealthBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerHealthBar.TabIndex = 8;
            this.PlayerHealthBar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Monsters_and_Demons.Properties.Resources.coin_bar_bg1;
            this.pictureBox1.Image = global::Monsters_and_Demons.Properties.Resources.coin1;
            this.pictureBox1.Location = new System.Drawing.Point(586, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::Monsters_and_Demons.Properties.Resources.coin_bar_bg1;
            this.label1.Location = new System.Drawing.Point(582, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 72);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // EnemyHealthBar
            // 
            this.EnemyHealthBar.BackColor = System.Drawing.Color.Black;
            this.EnemyHealthBar.BackgroundImage = global::Monsters_and_Demons.Properties.Resources.character_hp_bar_bg_RED1;
            this.EnemyHealthBar.Image = ((System.Drawing.Image)(resources.GetObject("EnemyHealthBar.Image")));
            this.EnemyHealthBar.Location = new System.Drawing.Point(468, 149);
            this.EnemyHealthBar.Name = "EnemyHealthBar";
            this.EnemyHealthBar.Size = new System.Drawing.Size(100, 15);
            this.EnemyHealthBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyHealthBar.TabIndex = 12;
            this.EnemyHealthBar.TabStop = false;
            // 
            // panelNextBattle
            // 
            this.panelNextBattle.BackColor = System.Drawing.Color.Transparent;
            this.panelNextBattle.Controls.Add(this.btnBottomWin);
            this.panelNextBattle.Controls.Add(this.pctrNextBattle);
            this.panelNextBattle.Location = new System.Drawing.Point(12, 9);
            this.panelNextBattle.Name = "panelNextBattle";
            this.panelNextBattle.Size = new System.Drawing.Size(200, 117);
            this.panelNextBattle.TabIndex = 13;
            // 
            // btnBottomWin
            // 
            this.btnBottomWin.BackColor = System.Drawing.Color.Transparent;
            this.btnBottomWin.BackgroundImage = global::Monsters_and_Demons.Properties.Resources.header1;
            this.btnBottomWin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBottomWin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBottomWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBottomWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBottomWin.Location = new System.Drawing.Point(3, 81);
            this.btnBottomWin.Name = "btnBottomWin";
            this.btnBottomWin.Size = new System.Drawing.Size(200, 36);
            this.btnBottomWin.TabIndex = 19;
            this.btnBottomWin.Text = "You Win! Next level";
            this.btnBottomWin.UseVisualStyleBackColor = false;
            // 
            // pctrNextBattle
            // 
            this.pctrNextBattle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctrNextBattle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctrNextBattle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrNextBattle.Image = global::Monsters_and_Demons.Properties.Resources.button_play;
            this.pctrNextBattle.Location = new System.Drawing.Point(0, 0);
            this.pctrNextBattle.Name = "pctrNextBattle";
            this.pctrNextBattle.Size = new System.Drawing.Size(200, 85);
            this.pctrNextBattle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrNextBattle.TabIndex = 0;
            this.pctrNextBattle.TabStop = false;
            this.pctrNextBattle.Click += new System.EventHandler(this.pctrNextBattle_Click);
            // 
            // lblBattleCounter
            // 
            this.lblBattleCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblBattleCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattleCounter.Location = new System.Drawing.Point(737, 323);
            this.lblBattleCounter.Name = "lblBattleCounter";
            this.lblBattleCounter.Size = new System.Drawing.Size(54, 23);
            this.lblBattleCounter.TabIndex = 14;
            this.lblBattleCounter.Text = "NULL";
            // 
            // lblBattleNumber
            // 
            this.lblBattleNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblBattleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattleNumber.Location = new System.Drawing.Point(622, 323);
            this.lblBattleNumber.Name = "lblBattleNumber";
            this.lblBattleNumber.Size = new System.Drawing.Size(122, 23);
            this.lblBattleNumber.TabIndex = 15;
            this.lblBattleNumber.Text = "Battle number: ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Monsters_and_Demons.Properties.Resources.character_energy_bar_frame1;
            this.pictureBox3.Location = new System.Drawing.Point(12, 349);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(414, 95);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pctrBattleLog
            // 
            this.pctrBattleLog.BackColor = System.Drawing.Color.Transparent;
            this.pctrBattleLog.BackgroundImage = global::Monsters_and_Demons.Properties.Resources.UI_board_Small__parchment;
            this.pctrBattleLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctrBattleLog.Location = new System.Drawing.Point(432, 349);
            this.pctrBattleLog.Name = "pctrBattleLog";
            this.pctrBattleLog.Size = new System.Drawing.Size(360, 95);
            this.pctrBattleLog.TabIndex = 17;
            this.pctrBattleLog.TabStop = false;
            // 
            // panelDeath
            // 
            this.panelDeath.BackColor = System.Drawing.Color.Transparent;
            this.panelDeath.Controls.Add(this.btnDeathTop);
            this.panelDeath.Controls.Add(this.btnDeathBottom);
            this.panelDeath.Controls.Add(this.pictureBox2);
            this.panelDeath.Location = new System.Drawing.Point(347, 65);
            this.panelDeath.Name = "panelDeath";
            this.panelDeath.Size = new System.Drawing.Size(115, 203);
            this.panelDeath.TabIndex = 18;
            this.panelDeath.Visible = false;
            // 
            // btnDeathTop
            // 
            this.btnDeathTop.BackColor = System.Drawing.Color.Transparent;
            this.btnDeathTop.BackgroundImage = global::Monsters_and_Demons.Properties.Resources.header___upsidedown;
            this.btnDeathTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeathTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeathTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeathTop.Location = new System.Drawing.Point(0, 0);
            this.btnDeathTop.Name = "btnDeathTop";
            this.btnDeathTop.Size = new System.Drawing.Size(115, 47);
            this.btnDeathTop.TabIndex = 21;
            this.btnDeathTop.Text = "UH OH! YOU LOSE!";
            this.btnDeathTop.UseVisualStyleBackColor = false;
            // 
            // btnDeathBottom
            // 
            this.btnDeathBottom.BackColor = System.Drawing.Color.Transparent;
            this.btnDeathBottom.BackgroundImage = global::Monsters_and_Demons.Properties.Resources.header1;
            this.btnDeathBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeathBottom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeathBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeathBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeathBottom.Location = new System.Drawing.Point(0, 155);
            this.btnDeathBottom.Name = "btnDeathBottom";
            this.btnDeathBottom.Size = new System.Drawing.Size(115, 47);
            this.btnDeathBottom.TabIndex = 20;
            this.btnDeathBottom.Text = "CONTINUE?";
            this.btnDeathBottom.UseVisualStyleBackColor = false;
            this.btnDeathBottom.Click += new System.EventHandler(this.btnDeath_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Monsters_and_Demons.Properties.Resources.icon_big_skull1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // txtboxBattleLog
            // 
            this.txtboxBattleLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(186)))), ((int)(((byte)(145)))));
            this.txtboxBattleLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxBattleLog.Location = new System.Drawing.Point(452, 359);
            this.txtboxBattleLog.Multiline = true;
            this.txtboxBattleLog.Name = "txtboxBattleLog";
            this.txtboxBattleLog.ReadOnly = true;
            this.txtboxBattleLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxBattleLog.Size = new System.Drawing.Size(323, 75);
            this.txtboxBattleLog.TabIndex = 19;
            this.txtboxBattleLog.TabStop = false;
            this.txtboxBattleLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGoldCoins
            // 
            this.lblGoldCoins.BackColor = System.Drawing.Color.Transparent;
            this.lblGoldCoins.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoldCoins.Image = ((System.Drawing.Image)(resources.GetObject("lblGoldCoins.Image")));
            this.lblGoldCoins.Location = new System.Drawing.Point(668, 24);
            this.lblGoldCoins.Name = "lblGoldCoins";
            this.lblGoldCoins.Size = new System.Drawing.Size(100, 33);
            this.lblGoldCoins.TabIndex = 20;
            this.lblGoldCoins.Text = "NULL";
            this.lblGoldCoins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(683, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 21;
            this.button1.Text = "Save Log";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monsters_and_Demons.Properties.Resources.ForestBattle1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblGoldCoins);
            this.Controls.Add(this.txtboxBattleLog);
            this.Controls.Add(this.panelDeath);
            this.Controls.Add(this.btnBackpack);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnSpells);
            this.Controls.Add(this.btnRunAway);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.PlayerHealthBar);
            this.Controls.Add(this.HunterStanding);
            this.Controls.Add(this.pctrBattleLog);
            this.Controls.Add(this.lblBattleCounter);
            this.Controls.Add(this.lblBattleNumber);
            this.Controls.Add(this.panelNextBattle);
            this.Controls.Add(this.EnemyHealthBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PctrMonster);
            this.Controls.Add(this.HunterAttacking);
            this.DoubleBuffered = true;
            this.Name = "Game";
            this.Text = "\\";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctrMonster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HunterStanding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HunterAttacking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHealthBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHealthBar)).EndInit();
            this.panelNextBattle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrNextBattle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBattleLog)).EndInit();
            this.panelDeath.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctrMonster;
        private System.Windows.Forms.PictureBox HunterStanding;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnSpells;
        private System.Windows.Forms.Button btnBackpack;
        private System.Windows.Forms.Button btnRunAway;
        private System.Windows.Forms.PictureBox HunterAttacking;
        private System.Windows.Forms.Timer TimerAttack;
        private System.Windows.Forms.PictureBox PlayerHealthBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox EnemyHealthBar;
        private System.Windows.Forms.Panel panelNextBattle;
        private System.Windows.Forms.PictureBox pctrNextBattle;
        private System.Windows.Forms.Label lblBattleCounter;
        private System.Windows.Forms.Label lblBattleNumber;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pctrBattleLog;
        private System.Windows.Forms.Panel panelDeath;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBottomWin;
        private System.Windows.Forms.Button btnDeathTop;
        private System.Windows.Forms.Button btnDeathBottom;
        private System.Windows.Forms.TextBox txtboxBattleLog;
        private System.Windows.Forms.Label lblGoldCoins;
        private System.Windows.Forms.Button button1;
    }
}