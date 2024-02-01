using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Traffic
{
    public partial class Form1 : Form
    {
        int tickCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.BringToFront();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Top += 35;
            pictureBox3.Top += 35;
            timer1.Stop();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tickCount++;
            if (tickCount == 10)
            {
                timer2.Stop();
                timer3.Start();
            }
            pictureBox2.Left -= 35;
            pictureBox2.BackgroundImage = Image.FromFile("C://Users//mrwiz//source//repos//Traffic//Traffic//Resources//carleft.png");
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            tickCount++;
            if (tickCount == 18)
            {
                timer3.Stop();
                timer4.Start();
            }
            pictureBox2.Top += 35;
            pictureBox2.BackgroundImage = Image.FromFile("C://Users//mrwiz//source//repos//Traffic//Traffic//Resources//cardown.png");
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            tickCount++;
            if (tickCount == 21)
            {
                timer4.Stop();
                timer5.Start();
            }
            pictureBox2.Left += 35;
            pictureBox2.BackgroundImage = Image.FromFile("C://Users//mrwiz//source//repos//Traffic//Traffic//Resources//carright.png");
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            tickCount++;
            if (tickCount == 25)
            {
                timer5.Stop();
                timer6.Start();
            }
            pictureBox2.Top += 35;
            pictureBox2.BackgroundImage = Image.FromFile("C://Users//mrwiz//source//repos//Traffic//Traffic//Resources//cardown.png");
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            tickCount++;
            if (tickCount == 31)
            {
                timer6.Stop();
            }
            pictureBox2.Left -= 35;
            pictureBox2.BackgroundImage = Image.FromFile("C://Users//mrwiz//source//repos//Traffic//Traffic//Resources//carleft.png");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            pictureBox2.BringToFront();
            pictureBox3.BringToFront();
            timer1.Start();
        }
    }
}
