
namespace TaipinguReisu
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
            this.gamePanel1 = new System.Windows.Forms.Panel();
            this.token = new System.Windows.Forms.PictureBox();
            this.textScore = new System.Windows.Forms.Label();
            this.geemuObaText = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.rndCar4 = new System.Windows.Forms.PictureBox();
            this.rndCar3 = new System.Windows.Forms.PictureBox();
            this.rndCar2 = new System.Windows.Forms.PictureBox();
            this.rndCar1 = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.roadTrack = new System.Windows.Forms.PictureBox();
            this.roadTrack2 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.bgImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timeText = new System.Windows.Forms.Label();
            this.gamePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.token)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rndCar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rndCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rndCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rndCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gamePanel1
            // 
            this.gamePanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gamePanel1.Controls.Add(this.rndCar1);
            this.gamePanel1.Controls.Add(this.textScore);
            this.gamePanel1.Controls.Add(this.timeText);
            this.gamePanel1.Controls.Add(this.geemuObaText);
            this.gamePanel1.Controls.Add(this.btnStart);
            this.gamePanel1.Controls.Add(this.explosion);
            this.gamePanel1.Controls.Add(this.label1);
            this.gamePanel1.Controls.Add(this.token);
            this.gamePanel1.Controls.Add(this.rndCar4);
            this.gamePanel1.Controls.Add(this.rndCar3);
            this.gamePanel1.Controls.Add(this.rndCar2);
            this.gamePanel1.Controls.Add(this.player);
            this.gamePanel1.Controls.Add(this.roadTrack);
            this.gamePanel1.Controls.Add(this.roadTrack2);
            this.gamePanel1.Location = new System.Drawing.Point(379, 0);
            this.gamePanel1.Name = "gamePanel1";
            this.gamePanel1.Size = new System.Drawing.Size(600, 672);
            this.gamePanel1.TabIndex = 0;
            // 
            // token
            // 
            this.token.BackColor = System.Drawing.Color.Transparent;
            this.token.Image = global::TaipinguReisu.Properties.Resources.diamond;
            this.token.Location = new System.Drawing.Point(59, 118);
            this.token.Name = "token";
            this.token.Size = new System.Drawing.Size(52, 50);
            this.token.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.token.TabIndex = 10;
            this.token.TabStop = false;
            // 
            // textScore
            // 
            this.textScore.AutoSize = true;
            this.textScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textScore.Location = new System.Drawing.Point(53, 5);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(120, 32);
            this.textScore.TabIndex = 2;
            this.textScore.Text = "Score: 0";
            // 
            // geemuObaText
            // 
            this.geemuObaText.AutoSize = true;
            this.geemuObaText.BackColor = System.Drawing.Color.Transparent;
            this.geemuObaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.geemuObaText.Image = global::TaipinguReisu.Properties.Resources.geemuoba;
            this.geemuObaText.Location = new System.Drawing.Point(102, 190);
            this.geemuObaText.Name = "geemuObaText";
            this.geemuObaText.Size = new System.Drawing.Size(298, 58);
            this.geemuObaText.TabIndex = 5;
            this.geemuObaText.Text = "Game Over!";
            this.geemuObaText.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnStart.Location = new System.Drawing.Point(112, 317);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(288, 80);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Try Again?";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.restart);
            this.btnStart.MouseEnter += new System.EventHandler(this.tryAgainHover);
            this.btnStart.MouseLeave += new System.EventHandler(this.tryAgainHoverLeave);
            // 
            // rndCar4
            // 
            this.rndCar4.Image = global::TaipinguReisu.Properties.Resources.blueCar;
            this.rndCar4.Location = new System.Drawing.Point(342, 239);
            this.rndCar4.Name = "rndCar4";
            this.rndCar4.Size = new System.Drawing.Size(46, 90);
            this.rndCar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rndCar4.TabIndex = 9;
            this.rndCar4.TabStop = false;
            // 
            // rndCar3
            // 
            this.rndCar3.Image = global::TaipinguReisu.Properties.Resources.blackCar;
            this.rndCar3.Location = new System.Drawing.Point(209, 239);
            this.rndCar3.Name = "rndCar3";
            this.rndCar3.Size = new System.Drawing.Size(46, 90);
            this.rndCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rndCar3.TabIndex = 8;
            this.rndCar3.TabStop = false;
            // 
            // rndCar2
            // 
            this.rndCar2.BackColor = System.Drawing.Color.Transparent;
            this.rndCar2.Image = global::TaipinguReisu.Properties.Resources.whiteCar;
            this.rndCar2.Location = new System.Drawing.Point(477, 221);
            this.rndCar2.Name = "rndCar2";
            this.rndCar2.Size = new System.Drawing.Size(46, 90);
            this.rndCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rndCar2.TabIndex = 7;
            this.rndCar2.TabStop = false;
            // 
            // rndCar1
            // 
            this.rndCar1.Image = global::TaipinguReisu.Properties.Resources.blackCar;
            this.rndCar1.Location = new System.Drawing.Point(59, 230);
            this.rndCar1.Name = "rndCar1";
            this.rndCar1.Size = new System.Drawing.Size(46, 90);
            this.rndCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rndCar1.TabIndex = 6;
            this.rndCar1.TabStop = false;
            // 
            // explosion
            // 
            this.explosion.BackColor = System.Drawing.Color.Transparent;
            this.explosion.Image = global::TaipinguReisu.Properties.Resources.boom;
            this.explosion.Location = new System.Drawing.Point(342, 379);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(89, 111);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.explosion.TabIndex = 5;
            this.explosion.TabStop = false;
            this.explosion.Visible = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::TaipinguReisu.Properties.Resources.ae86;
            this.player.Location = new System.Drawing.Point(270, 572);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(48, 89);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            // 
            // roadTrack
            // 
            this.roadTrack.Image = global::TaipinguReisu.Properties.Resources.roadTrack2;
            this.roadTrack.Location = new System.Drawing.Point(0, -672);
            this.roadTrack.Name = "roadTrack";
            this.roadTrack.Size = new System.Drawing.Size(598, 672);
            this.roadTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack.TabIndex = 3;
            this.roadTrack.TabStop = false;
            // 
            // roadTrack2
            // 
            this.roadTrack2.BackColor = System.Drawing.Color.Transparent;
            this.roadTrack2.Image = global::TaipinguReisu.Properties.Resources.roadTrack2;
            this.roadTrack2.Location = new System.Drawing.Point(0, 0);
            this.roadTrack2.Name = "roadTrack2";
            this.roadTrack2.Size = new System.Drawing.Size(598, 672);
            this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack2.TabIndex = 4;
            this.roadTrack2.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // bgImage
            // 
            this.bgImage.Image = global::TaipinguReisu.Properties.Resources.bgImage;
            this.bgImage.Location = new System.Drawing.Point(0, 0);
            this.bgImage.Name = "bgImage";
            this.bgImage.Size = new System.Drawing.Size(1263, 672);
            this.bgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bgImage.TabIndex = 4;
            this.bgImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.BackColor = System.Drawing.Color.Transparent;
            this.timeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.timeText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeText.Location = new System.Drawing.Point(318, 8);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(154, 29);
            this.timeText.TabIndex = 12;
            this.timeText.Text = "Time: 0:0.00";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.gamePanel1);
            this.Controls.Add(this.bgImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "TaipinguReisa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.isKeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.isKeyup);
            this.gamePanel1.ResumeLayout(false);
            this.gamePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.token)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rndCar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rndCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rndCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rndCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.PictureBox roadTrack;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox roadTrack2;
        private System.Windows.Forms.PictureBox bgImage;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox rndCar1;
        private System.Windows.Forms.PictureBox rndCar2;
        private System.Windows.Forms.PictureBox rndCar4;
        private System.Windows.Forms.PictureBox rndCar3;
        private System.Windows.Forms.Label geemuObaText;
        private System.Windows.Forms.PictureBox token;
        private System.Windows.Forms.Label timeText;
        private System.Windows.Forms.Label label1;
    }


}

