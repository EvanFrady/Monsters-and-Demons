
namespace Monsters_and_Demons
{
    partial class MainMenu
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnInstruction = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.HunterStanding = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pctrHelp = new System.Windows.Forms.PictureBox();
            this.pctrAHH = new System.Windows.Forms.PictureBox();
            this.ChatTimerHelp = new System.Windows.Forms.Timer(this.components);
            this.ChatTimerAHH = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.HunterStanding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrAHH)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Location = new System.Drawing.Point(248, 65);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(303, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Monsters and Demons";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Transparent;
            this.btnNewGame.BackgroundImage = global::Monsters_and_Demons.Properties.Resources.paperScroll1;
            this.btnNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewGame.FlatAppearance.BorderSize = 0;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.Black;
            this.btnNewGame.Location = new System.Drawing.Point(12, 12);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(150, 50);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.TabStop = false;
            this.btnNewGame.Text = "NEW GAME";
            this.btnNewGame.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnInstruction
            // 
            this.btnInstruction.BackColor = System.Drawing.Color.Transparent;
            this.btnInstruction.BackgroundImage = global::Monsters_and_Demons.Properties.Resources.paperScroll1;
            this.btnInstruction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInstruction.FlatAppearance.BorderSize = 0;
            this.btnInstruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstruction.ForeColor = System.Drawing.Color.Black;
            this.btnInstruction.Location = new System.Drawing.Point(231, 12);
            this.btnInstruction.Name = "btnInstruction";
            this.btnInstruction.Size = new System.Drawing.Size(150, 50);
            this.btnInstruction.TabIndex = 6;
            this.btnInstruction.TabStop = false;
            this.btnInstruction.Text = "INSTRUCTIONS";
            this.btnInstruction.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnInstruction.UseVisualStyleBackColor = false;
            this.btnInstruction.Click += new System.EventHandler(this.btnInstruction_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.Transparent;
            this.btnOptions.BackgroundImage = global::Monsters_and_Demons.Properties.Resources.paperScroll1;
            this.btnOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.ForeColor = System.Drawing.Color.Black;
            this.btnOptions.Location = new System.Drawing.Point(439, 12);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(150, 50);
            this.btnOptions.TabIndex = 7;
            this.btnOptions.TabStop = false;
            this.btnOptions.Text = "CREDITS";
            this.btnOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Monsters_and_Demons.Properties.Resources.paperScroll1;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(638, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 50);
            this.btnExit.TabIndex = 8;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "EXIT";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // HunterStanding
            // 
            this.HunterStanding.BackColor = System.Drawing.Color.Transparent;
            this.HunterStanding.Image = global::Monsters_and_Demons.Properties.Resources.ancient_gobby_idle_animation_transparent_FINAL1;
            this.HunterStanding.Location = new System.Drawing.Point(127, 357);
            this.HunterStanding.Name = "HunterStanding";
            this.HunterStanding.Size = new System.Drawing.Size(81, 61);
            this.HunterStanding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HunterStanding.TabIndex = 9;
            this.HunterStanding.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Monsters_and_Demons.Properties.Resources.Cave_Goblin_animation_Transparent1;
            this.pictureBox1.Location = new System.Drawing.Point(300, 357);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Monsters_and_Demons.Properties.Resources.forest_goblin_animation_transparent_flipped1;
            this.pictureBox2.Location = new System.Drawing.Point(456, 357);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pctrHelp
            // 
            this.pctrHelp.BackColor = System.Drawing.Color.Transparent;
            this.pctrHelp.Image = global::Monsters_and_Demons.Properties.Resources.Speech_Bubble_Help1;
            this.pctrHelp.Location = new System.Drawing.Point(486, 278);
            this.pctrHelp.Name = "pctrHelp";
            this.pctrHelp.Size = new System.Drawing.Size(237, 73);
            this.pctrHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrHelp.TabIndex = 12;
            this.pctrHelp.TabStop = false;
            // 
            // pctrAHH
            // 
            this.pctrAHH.BackColor = System.Drawing.Color.Transparent;
            this.pctrAHH.Image = global::Monsters_and_Demons.Properties.Resources.Speech_Bubble_Ahhh1;
            this.pctrAHH.Location = new System.Drawing.Point(12, 278);
            this.pctrAHH.Name = "pctrAHH";
            this.pctrAHH.Size = new System.Drawing.Size(237, 73);
            this.pctrAHH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrAHH.TabIndex = 13;
            this.pctrAHH.TabStop = false;
            // 
            // ChatTimerHelp
            // 
            this.ChatTimerHelp.Enabled = true;
            this.ChatTimerHelp.Interval = 1000;
            this.ChatTimerHelp.Tick += new System.EventHandler(this.ChatTimerHelp_Tick);
            // 
            // ChatTimerAHH
            // 
            this.ChatTimerAHH.Enabled = true;
            this.ChatTimerAHH.Interval = 1000;
            this.ChatTimerAHH.Tick += new System.EventHandler(this.ChatTimerAHH_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(183)))), ((int)(((byte)(234)))));
            this.BackgroundImage = global::Monsters_and_Demons.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctrAHH);
            this.Controls.Add(this.pctrHelp);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HunterStanding);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnInstruction);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.HunterStanding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrAHH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnInstruction;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox HunterStanding;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pctrHelp;
        private System.Windows.Forms.PictureBox pctrAHH;
        private System.Windows.Forms.Timer ChatTimerHelp;
        private System.Windows.Forms.Timer ChatTimerAHH;
    }
}

