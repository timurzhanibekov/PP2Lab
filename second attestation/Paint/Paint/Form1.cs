using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Pen Pen;
        Graphics g;
        int k = 0;
        bool a = false;
        int x, x2;
        int y, y2 ;
        public Form1()
        {
            InitializeComponent();
            Pen = new Pen(Color.Green, 3);
            g = CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            a = true;
            x = e.Location.X;
            y = e.Location.Y;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (a)
            {
                e.Graphics.DrawLine(Pen, x, y, x2, y2);
            }

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            x2 = e.Location.X;
            y2 = e.Location.Y;
            /*if (a)
            { g.Clear(Color.White);
                g.DrawLine(Pen, x, y, x2, y2);
                //x = x2;
                //y = y2;
            }*/
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            g.DrawLine(Pen, x, y, x2, y2);
        }
    }
}