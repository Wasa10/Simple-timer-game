using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
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
        private void Startb_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();

        }

        private void Stopb_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            if (label1.Text == label2.Text && label2.Text == label3.Text)
            {
                MessageBox.Show("WINNER!!!");



            }
            else

            {
                MessageBox.Show("LOSER!!!");

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int sec = int.Parse(label1.Text);
            sec++;
            if (sec <= 10)
            {
                label1.Text = sec.ToString();
            }
            else
            {
                label1.Text = "0";
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            int sec = int.Parse(label2.Text);
            sec++;
            if (sec <= 10)
            {
                label2.Text = sec.ToString();
            }
            else
            {
                label2.Text = "0";
            }

        }
         private void timer3_Tick(object sender, EventArgs e)
        {
            int sec = int.Parse(label3.Text);
            sec++;
            if (sec <= 10)
            {
                label3.Text = sec.ToString();
            }
            else
            {
                label3.Text = "0";
            }
        }
    }
}
