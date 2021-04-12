
namespace Testt
{
    partial class FlappyBird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyBird));
            this.Game = new System.Windows.Forms.Timer(this.components);
            this.Idle = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.Leaderboard = new System.Windows.Forms.Button();
            this.LivesCounter = new System.Windows.Forms.Label();
            this.ScoreCounter = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Pipe1 = new System.Windows.Forms.PictureBox();
            this.Pipe2 = new System.Windows.Forms.PictureBox();
            this.Pipe3 = new System.Windows.Forms.PictureBox();
            this.Pipe4 = new System.Windows.Forms.PictureBox();
            this.Pipe5 = new System.Windows.Forms.PictureBox();
            this.Pipe7 = new System.Windows.Forms.PictureBox();
            this.Pipe6 = new System.Windows.Forms.PictureBox();
            this.Pipe8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe8)).BeginInit();
            this.SuspendLayout();
            // 
            // Game
            // 
            this.Game.Interval = 30;
            this.Game.Tick += new System.EventHandler(this.Game_Tick);
            // 
            // Idle
            // 
            this.Idle.Enabled = true;
            this.Idle.Interval = 70;
            this.Idle.Tick += new System.EventHandler(this.Idle_Tick);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Player.BackgroundImage")));
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(99, 341);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(91, 64);
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(318, 382);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // Leaderboard
            // 
            this.Leaderboard.Location = new System.Drawing.Point(458, 382);
            this.Leaderboard.Name = "Leaderboard";
            this.Leaderboard.Size = new System.Drawing.Size(75, 23);
            this.Leaderboard.TabIndex = 2;
            this.Leaderboard.Text = "Leaderboards";
            this.Leaderboard.UseVisualStyleBackColor = true;
            // 
            // LivesCounter
            // 
            this.LivesCounter.AutoSize = true;
            this.LivesCounter.BackColor = System.Drawing.Color.Transparent;
            this.LivesCounter.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesCounter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LivesCounter.Location = new System.Drawing.Point(39, 42);
            this.LivesCounter.Name = "LivesCounter";
            this.LivesCounter.Size = new System.Drawing.Size(78, 26);
            this.LivesCounter.TabIndex = 3;
            this.LivesCounter.Text = "Lives: 3";
            // 
            // ScoreCounter
            // 
            this.ScoreCounter.AutoSize = true;
            this.ScoreCounter.BackColor = System.Drawing.Color.Transparent;
            this.ScoreCounter.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreCounter.Location = new System.Drawing.Point(329, 31);
            this.ScoreCounter.Name = "ScoreCounter";
            this.ScoreCounter.Size = new System.Drawing.Size(46, 52);
            this.ScoreCounter.TabIndex = 4;
            this.ScoreCounter.Text = "0";
            this.ScoreCounter.Click += new System.EventHandler(this.label2_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(381, 411);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox17.BackgroundImage")));
            this.pictureBox17.Location = new System.Drawing.Point(801, 889);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(37, 128);
            this.pictureBox17.TabIndex = 0;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "Ground";
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox19.BackgroundImage")));
            this.pictureBox19.Location = new System.Drawing.Point(936, 889);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(37, 128);
            this.pictureBox19.TabIndex = 0;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Tag = "Ground";
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox21.BackgroundImage")));
            this.pictureBox21.Location = new System.Drawing.Point(868, 889);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(37, 128);
            this.pictureBox21.TabIndex = 0;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Tag = "Ground";
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox23.BackgroundImage")));
            this.pictureBox23.Location = new System.Drawing.Point(1003, 889);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(37, 128);
            this.pictureBox23.TabIndex = 0;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.Tag = "Ground";
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox25.BackgroundImage")));
            this.pictureBox25.Location = new System.Drawing.Point(835, 889);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(37, 128);
            this.pictureBox25.TabIndex = 0;
            this.pictureBox25.TabStop = false;
            this.pictureBox25.Tag = "Ground";
            // 
            // pictureBox27
            // 
            this.pictureBox27.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox27.BackgroundImage")));
            this.pictureBox27.Location = new System.Drawing.Point(970, 889);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(37, 128);
            this.pictureBox27.TabIndex = 0;
            this.pictureBox27.TabStop = false;
            this.pictureBox27.Tag = "Ground";
            // 
            // pictureBox29
            // 
            this.pictureBox29.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox29.BackgroundImage")));
            this.pictureBox29.Location = new System.Drawing.Point(902, 889);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(37, 128);
            this.pictureBox29.TabIndex = 0;
            this.pictureBox29.TabStop = false;
            this.pictureBox29.Tag = "Ground";
            // 
            // pictureBox30
            // 
            this.pictureBox30.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox30.BackgroundImage")));
            this.pictureBox30.Location = new System.Drawing.Point(768, 889);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(37, 128);
            this.pictureBox30.TabIndex = 0;
            this.pictureBox30.TabStop = false;
            this.pictureBox30.Tag = "Ground";
            // 
            // pictureBox31
            // 
            this.pictureBox31.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox31.BackgroundImage")));
            this.pictureBox31.Location = new System.Drawing.Point(1037, 889);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(37, 128);
            this.pictureBox31.TabIndex = 0;
            this.pictureBox31.TabStop = false;
            this.pictureBox31.Tag = "Ground";
            // 
            // Ground
            // 
            this.Ground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ground.BackgroundImage")));
            this.Ground.Location = new System.Drawing.Point(-3, 896);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1102, 182);
            this.Ground.TabIndex = 6;
            this.Ground.TabStop = false;
            // 
            // Pipe1
            // 
            this.Pipe1.BackColor = System.Drawing.Color.Green;
            this.Pipe1.Location = new System.Drawing.Point(781, -535);
            this.Pipe1.Name = "Pipe1";
            this.Pipe1.Size = new System.Drawing.Size(100, 913);
            this.Pipe1.TabIndex = 7;
            this.Pipe1.TabStop = false;
            this.Pipe1.Tag = "Pipe";
            this.Pipe1.Click += new System.EventHandler(this.Pipe1_Click);
            // 
            // Pipe2
            // 
            this.Pipe2.BackColor = System.Drawing.Color.Green;
            this.Pipe2.Location = new System.Drawing.Point(781, 550);
            this.Pipe2.Name = "Pipe2";
            this.Pipe2.Size = new System.Drawing.Size(100, 1113);
            this.Pipe2.TabIndex = 7;
            this.Pipe2.TabStop = false;
            this.Pipe2.Tag = "Pipe";
            this.Pipe2.Click += new System.EventHandler(this.Pipe1_Click);
            // 
            // Pipe3
            // 
            this.Pipe3.BackColor = System.Drawing.Color.Green;
            this.Pipe3.Location = new System.Drawing.Point(1111, -535);
            this.Pipe3.Name = "Pipe3";
            this.Pipe3.Size = new System.Drawing.Size(100, 913);
            this.Pipe3.TabIndex = 7;
            this.Pipe3.TabStop = false;
            this.Pipe3.Tag = "Pipe";
            this.Pipe3.Click += new System.EventHandler(this.Pipe1_Click);
            // 
            // Pipe4
            // 
            this.Pipe4.BackColor = System.Drawing.Color.Green;
            this.Pipe4.Location = new System.Drawing.Point(1111, 550);
            this.Pipe4.Name = "Pipe4";
            this.Pipe4.Size = new System.Drawing.Size(100, 1113);
            this.Pipe4.TabIndex = 7;
            this.Pipe4.TabStop = false;
            this.Pipe4.Tag = "Pipe";
            this.Pipe4.Click += new System.EventHandler(this.Pipe1_Click);
            // 
            // Pipe5
            // 
            this.Pipe5.BackColor = System.Drawing.Color.Green;
            this.Pipe5.Location = new System.Drawing.Point(1360, -535);
            this.Pipe5.Name = "Pipe5";
            this.Pipe5.Size = new System.Drawing.Size(100, 913);
            this.Pipe5.TabIndex = 7;
            this.Pipe5.TabStop = false;
            this.Pipe5.Tag = "Pipe";
            this.Pipe5.Click += new System.EventHandler(this.Pipe1_Click);
            // 
            // Pipe7
            // 
            this.Pipe7.BackColor = System.Drawing.Color.Green;
            this.Pipe7.Location = new System.Drawing.Point(1690, -535);
            this.Pipe7.Name = "Pipe7";
            this.Pipe7.Size = new System.Drawing.Size(100, 913);
            this.Pipe7.TabIndex = 7;
            this.Pipe7.TabStop = false;
            this.Pipe7.Tag = "Pipe";
            this.Pipe7.Click += new System.EventHandler(this.Pipe1_Click);
            // 
            // Pipe6
            // 
            this.Pipe6.BackColor = System.Drawing.Color.Green;
            this.Pipe6.Location = new System.Drawing.Point(1360, 550);
            this.Pipe6.Name = "Pipe6";
            this.Pipe6.Size = new System.Drawing.Size(100, 1113);
            this.Pipe6.TabIndex = 7;
            this.Pipe6.TabStop = false;
            this.Pipe6.Tag = "Pipe";
            this.Pipe6.Click += new System.EventHandler(this.Pipe1_Click);
            // 
            // Pipe8
            // 
            this.Pipe8.BackColor = System.Drawing.Color.Green;
            this.Pipe8.Location = new System.Drawing.Point(1690, 550);
            this.Pipe8.Name = "Pipe8";
            this.Pipe8.Size = new System.Drawing.Size(100, 1113);
            this.Pipe8.TabIndex = 7;
            this.Pipe8.TabStop = false;
            this.Pipe8.Tag = "Pipe";
            this.Pipe8.Click += new System.EventHandler(this.Pipe1_Click);
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(752, 985);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.ScoreCounter);
            this.Controls.Add(this.LivesCounter);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.Pipe8);
            this.Controls.Add(this.Pipe4);
            this.Controls.Add(this.Pipe6);
            this.Controls.Add(this.Pipe7);
            this.Controls.Add(this.Pipe2);
            this.Controls.Add(this.Pipe5);
            this.Controls.Add(this.Pipe3);
            this.Controls.Add(this.Pipe1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Leaderboard);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.pictureBox31);
            this.Controls.Add(this.pictureBox30);
            this.Controls.Add(this.pictureBox29);
            this.Controls.Add(this.pictureBox27);
            this.Controls.Add(this.pictureBox25);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox17);
            this.DoubleBuffered = true;
            this.Name = "FlappyBird";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FlappyBird_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Game;
        private System.Windows.Forms.Timer Idle;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Leaderboard;
        private System.Windows.Forms.Label LivesCounter;
        private System.Windows.Forms.Label ScoreCounter;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.PictureBox pictureBox27;
        private System.Windows.Forms.PictureBox pictureBox29;
        private System.Windows.Forms.PictureBox pictureBox30;
        private System.Windows.Forms.PictureBox pictureBox31;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox Pipe1;
        private System.Windows.Forms.PictureBox Pipe2;
        private System.Windows.Forms.PictureBox Pipe3;
        private System.Windows.Forms.PictureBox Pipe4;
        private System.Windows.Forms.PictureBox Pipe5;
        private System.Windows.Forms.PictureBox Pipe7;
        private System.Windows.Forms.PictureBox Pipe6;
        private System.Windows.Forms.PictureBox Pipe8;
    }
}

