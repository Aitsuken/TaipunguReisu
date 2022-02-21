
namespace TaipinguReisu
{
    partial class GameMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMenu));
            this.titleText = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.aboutText = new System.Windows.Forms.Label();
            this.soundButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.BackColor = System.Drawing.Color.Transparent;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.titleText.Image = global::TaipinguReisu.Properties.Resources.menu;
            this.titleText.Location = new System.Drawing.Point(1044, 524);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(193, 78);
            this.titleText.TabIndex = 0;
            this.titleText.Text = "Inishiaru Ji\r\nby Aitsuken";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.startButton.Image = global::TaipinguReisu.Properties.Resources.button;
            this.startButton.Location = new System.Drawing.Point(131, 60);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(182, 72);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.exitButton.Image = global::TaipinguReisu.Properties.Resources.button;
            this.exitButton.Location = new System.Drawing.Point(131, 368);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(182, 72);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.settingsButton.Image = global::TaipinguReisu.Properties.Resources.button;
            this.settingsButton.Location = new System.Drawing.Point(131, 164);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(182, 72);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.aboutButton.Image = global::TaipinguReisu.Properties.Resources.button;
            this.aboutButton.Location = new System.Drawing.Point(131, 267);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(182, 72);
            this.aboutButton.TabIndex = 4;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.backButton.Image = global::TaipinguReisu.Properties.Resources.button;
            this.backButton.Location = new System.Drawing.Point(391, 368);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(182, 72);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // aboutText
            // 
            this.aboutText.AutoSize = true;
            this.aboutText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.aboutText.Location = new System.Drawing.Point(386, 87);
            this.aboutText.Name = "aboutText";
            this.aboutText.Size = new System.Drawing.Size(349, 232);
            this.aboutText.TabIndex = 6;
            this.aboutText.Text = resources.GetString("aboutText.Text");
            this.aboutText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aboutText.Visible = false;
            // 
            // soundButton
            // 
            this.soundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.soundButton.Image = global::TaipinguReisu.Properties.Resources.button;
            this.soundButton.Location = new System.Drawing.Point(391, 140);
            this.soundButton.Name = "soundButton";
            this.soundButton.Size = new System.Drawing.Size(217, 72);
            this.soundButton.TabIndex = 7;
            this.soundButton.Text = "Sound: On";
            this.soundButton.UseVisualStyleBackColor = true;
            this.soundButton.Visible = false;
            this.soundButton.Click += new System.EventHandler(this.soundButton_Click);
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.soundButton);
            this.Controls.Add(this.aboutText);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameMenu";
            this.Text = "TaipinguReisa";
            this.Load += new System.EventHandler(this.GameMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label aboutText;
        private System.Windows.Forms.Button soundButton;
    }
}