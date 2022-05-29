using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
            restart.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            coins(gamespeed);
            coinscollection();
        }

        Random R = new Random();
        int x, y;
        void enemy(int speed)
        {
            if (enemy1.Top >= 450)
            {
                x = R.Next(0, 200);
                enemy1.Location = new Point(x, 0);
            }
            else { enemy1.Top += speed; }

            if (enemy2.Top >= 450)
            {
                x = R.Next(0, 400);
                enemy2.Location = new Point(x, 0);
            }
            else { enemy2.Top += speed; }

            if (enemy3.Top >= 450)
            {
                x = R.Next(100, 250);
                enemy3.Location = new Point(x, 0);
            }
            else { enemy3.Top += speed; }

        }

        int collectedcoins = 0;
        void coins(int speed)
        {
            if (coin1.Top >= 450)
            {
                x = R.Next(0, 200);
                coin1.Location = new Point(x, 0);
            }
            else { coin1.Top += speed; }

            if (coin2.Top >= 450)
            {
                x = R.Next(0, 200);
                coin2.Location = new Point(x, 0);
            }
            else { coin2.Top += speed; }

            if (coin3.Top >= 450)
            {
                x = R.Next(0, 200);
                coin3.Location = new Point(x, 0);
            }
            else { coin3.Top += speed; }

            if (coin4.Top >= 450)
            {
                x = R.Next(0, 200);
                coin4.Location = new Point(x, 0);
            }
            else { coin4.Top += speed; }
        }

        void coinscollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoins++;
                label1.Text = "Coins=" + collectedcoins.ToString();
                x = R.Next(100, 250);
                coin1.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoins++;
                label1.Text = "Coins=" + collectedcoins.ToString();
                x = R.Next(100, 250);
                coin2.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoins++;
                label1.Text = "Coins=" + collectedcoins.ToString();
                x = R.Next(100, 250);
                coin3.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoins++;
                label1.Text = "Coins=" + collectedcoins.ToString();
                x = R.Next(100, 250);
                coin4.Location = new Point(x, 0);
            }
        }

        void gameover()
        {
            if(car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
                restart.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
                restart.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
                restart.Visible = true;
            }
        }

        void moveline(int speed)
        {
             if(pictureBox2.Top >= 450)
             { pictureBox2.Top = 0; }
             else { pictureBox2.Top += speed; }

             if(pictureBox3.Top >= 450)
             { pictureBox3.Top = 0; }
             else { pictureBox3.Top += speed; }

             if (pictureBox6.Top >= 450)
             { pictureBox6.Top = 0; }
             else { pictureBox6.Top += speed; }

                
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        int gamespeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left )
            {
                if(car.Left > 10)
                car.Left += -8;
            }
            if(e.KeyCode == Keys.Right)
            {
                if(car.Right < 270)
                car.Left += 8;
            }
            if(e.KeyCode == Keys.Up)
            {
                if(gamespeed < 21)
                { gamespeed++; }
            }
            if(e.KeyCode == Keys.Down)
            {
                if(gamespeed > 0)
                { gamespeed--; }
            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }
    }
}
