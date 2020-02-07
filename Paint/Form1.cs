using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Pen p = new Pen(Color.Black);
        int tamaño = 1;
        Graphics g;
        int x, y;
        Color color=Color.Black;
        Boolean c1=false, c2=false,pluma=true,cd=false; 
        public Form1()
        {
            InitializeComponent();
            gr();
        }
        public void gr(){

            g = pictureBox1.CreateGraphics();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            color = button1.BackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            color = button2.BackColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            color = button3.BackColor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            color = button4.BackColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            color = button5.BackColor;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            color = button10.BackColor;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            color = button9.BackColor;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            color = button8.BackColor;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            color = button7.BackColor;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            color = button6.BackColor;
        }

        private void bc1_Click(object sender, EventArgs e)
        {
            color = bc1.BackColor;
            c1 = true;
            c2 = false;
        }

        private void bc2_Click(object sender, EventArgs e)
        {
            color = bc2.BackColor;
            c1 = false;
            c2 = true;
        }

        private void btn_pluma_Click(object sender, EventArgs e)
        {
            pluma = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            cd = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (cd)
            {
                p = new Pen(color);
                p.Width = tamaño;
                g.DrawLine(p, x, y, e.X, e.Y);
                //g.DrawLine(new Pen(color), new Point(x-(tamaño/2), y-(tamaño/2)), new Point(e.X+tamaño, e.Y+tamaño));
                x = e.X;
                y = e.Y;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            cd = false;
            //g.DrawLine(new Pen(color),new Point(x,y),new Point(e.X,e.Y));
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                tamaño = int.Parse(textBox1.Text);
            }
            catch (Exception ex) {
                tamaño = 1;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Size = this.Size;
            gr();
        }
    }
}
