using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAR_RACE_GAME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblgame.Visible = false;
            btnretry.Visible = false;
            btnexit.Visible = false;
            lblscore.Visible = false;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemey(gamespeed);
            gameover();
            coins(gamespeed);
            points();
        }

        int coin_count = 0;

        void points()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                coin_count++;
                lblcoin.Text = "POINTS : " + coin_count.ToString();
                x = r.Next(0, 200);
                // y = r.Next(0, 400);
                coin1.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                coin_count++;
                lblcoin.Text = "POINTS : " + coin_count.ToString();
                x = r.Next(0, 200);
                // y = r.Next(0, 400);
                coin2.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                coin_count++;
                lblcoin.Text = "POINTS : " + coin_count.ToString();
                x = r.Next(0, 200);
                // y = r.Next(0, 400);
                coin3.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                coin_count++;
                lblcoin.Text = "POINTS : " + coin_count.ToString();
                x = r.Next(0, 200);
                // y = r.Next(0, 400);
                coin4.Location = new Point(x, 0);
            }
        }
        void gameover()
        {
            if(car.Bounds.IntersectsWith(enemey1.Bounds))
            {
                timer1.Enabled = false;
                lblgame.Visible = true; lblgame.BringToFront();
                btnretry.Visible = true;
                btnexit.Visible = true;
                lblscore.Visible = true;
                lblscore.Text = "SCORE : " + coin_count.ToString();
            }

            if (car.Bounds.IntersectsWith(enemey2.Bounds))
            {
                timer1.Enabled = false;
                lblgame.Visible = true; lblgame.BringToFront();
                btnretry.Visible = true;
                btnexit.Visible = true;
                lblscore.Visible = true;
                lblscore.Text = "SCORE : " + coin_count.ToString();
               
            }

            if (car.Bounds.IntersectsWith(enemey3.Bounds))
            {
                timer1.Enabled = false;
                lblgame.Visible = true;
                lblgame.BringToFront();
                btnretry.Visible = true;
                btnexit.Visible = true;
                lblscore.Visible = true;
                lblscore.Text = "SCORE : " + coin_count.ToString();
            }
        }
        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            { pictureBox1.Top = 0; }
            else { pictureBox1.Top += speed;  }
            if (pictureBox2.Top >= 500)
            { pictureBox2.Top = 0; }
            else { pictureBox2.Top += speed; }
            if (pictureBox3.Top >= 500)
            { pictureBox3.Top = 0; }
            else { pictureBox3.Top += speed; }
            if (pictureBox4.Top >= 500)
            { pictureBox4.Top = 0; }
            else { pictureBox4.Top += speed; }
            if (pictureBox7.Top >= 500)
            { pictureBox7.Top = 0; }
            else { pictureBox7.Top += speed; }
        }

        // ENEMEY CAR FUNCTION
        Random r = new Random();
        int x;
        void enemey(int speed)
        {
            if (enemey1.Top >= 500)
            { x=r.Next(0,200);
            // y = r.Next(0, 400);
            enemey1.Location = new Point(x,0);
            }
            else { enemey1.Top += speed;  }

            if (enemey2.Top >= 500)
            {
                x = r.Next(0, 400);
                // y = r.Next(0, 400);
                enemey2.Location = new Point(x, 0);
            }
            else { enemey2.Top += speed; }

            if (enemey3.Top >= 500)
            {
                x = r.Next(200,350);
                // y = r.Next(0, 400);
                enemey3.Location = new Point(x, 0);
            }
            else { enemey3.Top += speed; }
        }

        void coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(0, 200);
               coin1.Location = new Point(x, 0);
            }
            else { coin1.Top += speed; }
            if (coin2.Top >= 500)
            {
                x = r.Next(0, 300);
                coin2.Location = new Point(x, 0);
            }
            else { coin2.Top += speed; }
            if (coin3.Top >= 500)
            {
                x = r.Next(0, 350);
                coin3.Location = new Point(x, 0);
            }
            else { coin3.Top += speed; }
            if (coin4.Top >= 500)
            {
                x = r.Next(0, 250);
                coin4.Location = new Point(x, 0);
            }
            else { coin4.Top += speed; }
        }

        int gamespeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if(e.KeyCode==Keys.Left)
            {
                if(car.Left>0)
                car.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 280)
                    car.Left += 8;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                { gamespeed++; }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                { gamespeed=0; }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnretry_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            
        }
         /*if (KeyCode == Keys.Enter)
                {
                    InitializeComponent();
                   // Form1 F1 = new Form1();
                   // F1.Show();
                } */
    }
}
