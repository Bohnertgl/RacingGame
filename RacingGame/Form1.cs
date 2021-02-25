using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Line1_Click(object sender, EventArgs e)
        {
            
        }
        private void Line2_Click(object sender, EventArgs e)
        {

        }
        private void Line3_Click(object sender, EventArgs e)
        {

        }
        private void car_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(5);
        }
        void moveline(int speed)
        {
            if (Line1.Top >= 500)
            {
                Line1.Top = 0;
            }
            else
            {
                Line1.Top += speed;
            }

            if (Line2.Top >= 500)
            {
                Line2.Top = 0;
            }
            else
            {
                Line2.Top += speed;
            }

            if (Line3.Top >= 500)
            {
                Line3.Top = 0;
            }
            else
            {
                Line3.Top += speed;
            }
        }
        int gamespeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left > 0)
                    car.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 380)
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
                { gamespeed--; }
            }
        }
    }
}
