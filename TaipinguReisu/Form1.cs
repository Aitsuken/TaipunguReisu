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
    public partial class Game : Form
    {


        int roadSpeed = 12;
        int rndCarsSpeed = 3;

        int playerSpeed = 12;

        int score;
        int tokensScore;
        int carImage;

        Random rand = new Random();
        Random rndCar = new Random();

        //sound players
        SoundPlayer deathS = new SoundPlayer(Properties.Resources.deathsnd);


        SoundPlayer musicSnd;

        bool goleft, goright;
        public Game()
        {
            InitializeComponent();
            resetGame();

        }

        private void restart(object sender, EventArgs e)
        {
            resetGame();
        }

        private void resetGame()
        {
            textScore.Visible = false;
            geemuObaText.Visible = false;
            btnStart.Visible = false;
            token.Visible = true;
            //musicSnd.Stop();
            deathS.Stop();

            //play music

            int muzon = rand.Next(1, 3);
            switch (muzon)
            {
                case 1:
                    musicSnd = new SoundPlayer(Properties.Resources.InitialD_Running90s);
                    break;
                case 2:
                    musicSnd = new SoundPlayer(Properties.Resources.InitialD_Dejavu);
                    break;
            }
            musicSnd.Play();


            //init
            btnStart.Enabled = false;
            explosion.Visible = false;
            goleft = false;
            goright = false;

            score = 0;
            tokensScore = 0;

            roadSpeed = 13;
            rndCarsSpeed = 6;
            rndCar1.Top = rndCar.Next(0, 100) * 1;
            rndCar1.Left = rndCar.Next(35, 200);


            rndCar2.Top = rndCar.Next(200, 400) * -1;
            rndCar2.Left = rndCar.Next(230, 350);

            rndCar3.Top = rndCar.Next(0, 100) * 1;
            rndCar3.Left = rndCar.Next(230, 350);

            rndCar4.Top = rndCar.Next(25, 200) * -1;
            rndCar4.Left = rndCar.Next(25, 200);
            gameTimer.Start();
            
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            
            score++;

            if(goleft == true && player.Left > 30)
            {
                player.Left -= playerSpeed;
            }

            if (goright == true && player.Left < 390)
            {
                player.Left += playerSpeed;
            }


            roadTrack.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;


            if (roadTrack2.Top > 576)
            {
                roadTrack2.Top = -500;
            }

            if (roadTrack.Top > 576)
            {
                roadTrack.Top = -500;
            }




            rndCar1.Top += rndCarsSpeed;
            rndCar2.Top += rndCarsSpeed;
            rndCar3.Top += rndCarsSpeed;
            rndCar4.Top += rndCarsSpeed;

            token.Top += roadSpeed;
            if(token.Top > 672)
            {
                ChangeToken(token);
            }

            if (rndCar1.Top > 672)
            {
                ChangeCar(rndCar1);
            }

            if (rndCar2.Top > 672)
            {
                ChangeCar(rndCar2);
            }

            if (rndCar3.Top > 672)
            {
                ChangeCar(rndCar3);
            }

            if (rndCar4.Top > 672)
            {
                ChangeCar(rndCar4);
            }

            while(rndCar1.Bounds.IntersectsWith(rndCar2.Bounds) ||
                rndCar1.Bounds.IntersectsWith(rndCar3.Bounds) ||
                rndCar1.Bounds.IntersectsWith(rndCar4.Bounds))
            {
                ChangeCar(rndCar1);
            }

            while (rndCar2.Bounds.IntersectsWith(rndCar1.Bounds) ||
    rndCar2.Bounds.IntersectsWith(rndCar3.Bounds) ||
    rndCar2.Bounds.IntersectsWith(rndCar4.Bounds))
            {
                ChangeCar(rndCar2);
            }

            while (rndCar3.Bounds.IntersectsWith(rndCar1.Bounds) ||
rndCar3.Bounds.IntersectsWith(rndCar2.Bounds) ||
rndCar3.Bounds.IntersectsWith(rndCar4.Bounds))
            {
                ChangeCar(rndCar3);
            }

            if (player.Bounds.IntersectsWith(rndCar1.Bounds) || 
                player.Bounds.IntersectsWith(rndCar2.Bounds) ||
                player.Bounds.IntersectsWith(rndCar3.Bounds) ||
                player.Bounds.IntersectsWith(rndCar4.Bounds))
            {
                gameOver();
            }

            if (player.Bounds.IntersectsWith(token.Bounds)){
                tokensScore += 100;
                ChangeToken(token);
            }

            if(score > 500)
            {
                roadSpeed = 20;
                rndCarsSpeed = 14;
            }

            if (score > 1500)
            {
                roadSpeed = 25;
                rndCarsSpeed = 20;
            }

            if(score > 2500)
            {
                roadSpeed = 35;
                rndCarsSpeed = 30;
            }
        }

        private void gameOver()
        {
            deathS.Play();
            token.Visible = false;
            score += tokensScore;
            textScore.Text = "Score: " + score;
            textScore.Visible = true;
            geemuObaText.Visible = true;
            btnStart.Visible = true;
            //deathS.SoundLocation = "Sound.wav";


            gameTimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(4, -15);
            explosion.BackColor = Color.Transparent;
            btnStart.Enabled = true;
        }

       private void ChangeToken(PictureBox token)
        {
            token.Top = rand.Next(-400, -50);
            token.Left = 50 + 90 * rand.Next(0, 4);
        }
        private void ChangeCar(PictureBox tCar)
        {
            carImage = rand.Next(1, 6);

            switch (carImage)
            {
                case 1:
                    tCar.Image = Properties.Resources.blackCar;
                    break;
                case 2:
                    tCar.Image = Properties.Resources.redBird;
                    break;
                case 3:
                    tCar.Image = Properties.Resources.whiteCar;
                    break;
                case 4:
                    tCar.Image = Properties.Resources.blueCar;
                    break;
                case 5:
                    tCar.Image = Properties.Resources.grayCar;
                    break;

            }

            tCar.Top = rndCar.Next(-300, -20);
            tCar.Left = rndCar.Next(30, 370);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
                //this.TopMost = true;
                //this.FormBorderStyle = FormBorderStyle.None;
                //this.WindowState = FormWindowState.Maximized;
        }

        private void isKeydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goleft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }

            if(e.KeyCode == Keys.Delete)
            {
                if (gameTimer.Enabled)
                {
                    gameOver();
                }
                
            }

        }


        private void isKeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }
    }
}
