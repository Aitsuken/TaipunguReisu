using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace TaipinguReisu
{
    public partial class GameMenu : Form
    {

        int soundBtnClicked = 0;
        SoundPlayer menuMusic = new SoundPlayer(Properties.Resources.InitialD_OP);
        public GameMenu()
        {
            InitializeComponent();
            menuMusic.PlayLooping();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GameMenu_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            aboutButton.Visible = false;
            exitButton.Visible = false;
            startButton.Visible = false;
            settingsButton.Visible = false;

            aboutText.Visible = true;
            backButton.Visible = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            aboutButton.Visible = true;
            exitButton.Visible = true;
            startButton.Visible = true;
            settingsButton.Visible = true;

            soundButton.Visible = false;
            aboutText.Visible = false;
            backButton.Visible = false;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            aboutButton.Visible = false;
            exitButton.Visible = false;
            startButton.Visible = false;
            settingsButton.Visible = false;
            aboutText.Visible = false;

            soundButton.Visible = true;
            backButton.Visible = true;
        }

        private void soundButton_Click(object sender, EventArgs e)
        {
            soundBtnClicked++;
            if(soundBtnClicked % 2 != 0)
            {
                soundButton.Text = "Sound: Off";
                menuMusic.Stop();
            }
            else
            {
                soundButton.Text = "Sound: On";
                menuMusic.PlayLooping();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Game geemu = new Game();
            geemu.ShowDialog();
        }
    }
}
