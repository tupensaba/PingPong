using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        private int speed_hor = 4;
        private int speed_vertical = 4;
        private int score = 0;

        public Form1()
        {
            InitializeComponent();
            timer.Enabled = true;


            this.Bounds = Screen.PrimaryScreen.Bounds;

            gamePanel.Top = backpanel.Bottom - (backpanel.Bottom / 10);
            loseLabel.Top = (backpanel.Height / 2) - (loseLabel.Height / 2);
            loseLabel.Left = (backpanel.Width / 2) - (loseLabel.Width / 2);
            
            loseLabel.Visible = false;


        }


       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //gamePanel.Left = Cursor.Position.X - (gamePanel.Width / 2);

            gameBall.Left += speed_hor;
            gameBall.Top += speed_vertical;

            
            if(gameBall.Left <= backpanel.Left)
            {
                speed_hor *= -1;
            }
            
            
            if(gameBall.Right >= backpanel.Right)
            {
                speed_hor *= -1;
            }
            
            
            if(gameBall.Top <= backpanel.Top)
            {
                speed_vertical *= -1;
            }
            
            
            if(gameBall.Bottom >= backpanel.Bottom)
            {
                loseLabel.Visible = true;
                timer.Enabled = false;
            }
           
            
            if(gameBall.Bottom >= gamePanel.Top 
                && 
                gameBall.Bottom <= gamePanel.Bottom
                && 
                gameBall.Left >= gamePanel.Left
                && 
                gameBall.Right <= gamePanel.Right)
            {
                speed_hor += 3;
                speed_vertical += 3;
                speed_vertical *= -1;
                score += 1;
                result.Text = "Счет: " + score.ToString(); 

            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {   int speedPlatform = 50;
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            

               
            if(e.KeyCode == Keys.A && gamePanel.Left >= backpanel.Left)
            {
                gamePanel.Left -= speedPlatform;

            }
               
            if(e.KeyCode == Keys.D && gamePanel.Right <= backpanel.Right)
            {
                gamePanel.Left += speedPlatform;
            }
            if(e.KeyCode == Keys.R)
            {
                Random pos = new Random();
                gameBall.Top = pos.Next(50,100);
                gameBall.Left = pos.Next(500,1000 );
                speed_hor = 4;
                speed_vertical = 4;
                score = 0;
                result.Text = "Cчет: 0";
                timer.Enabled = true;
                loseLabel.Visible = false;
            }
        }
    }
}
