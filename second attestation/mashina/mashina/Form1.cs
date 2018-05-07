using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mashina
{
    public partial class Form1 : Form
    {
        int a = 5;
        Pen pen;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            timer1.Start();
        }
        Pen p = new Pen(Color.Black, 2);

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawRectangle(p, 200, 200, 200, 70);
            g.DrawRectangle(p, 250, 150, 100, 50);
            g.DrawEllipse(p, new Rectangle(225, 270, 40, 40));
            g.DrawEllipse(p, new Rectangle(325, 270, 40, 40));
        }
        int dx = 100;
        private void timer1_Tick(object sender, EventArgs e)
        {
            dx += a;
            g.Clear(Color.White);
            g.DrawRectangle(p, dx + 200, 200, 200, 70);
            g.DrawRectangle(p, dx + 250, 150, 100, 50);
            g.DrawEllipse(p, new Rectangle(dx + 225, 270, 40, 40));
            g.DrawEllipse(p, new Rectangle(dx + 325, 270, 40, 40));
            g.DrawLine(p, 0, 310, Width, 310);
            if (dx == 600)
            {
                a = -1*a;
            }
            if (dx == 0)
            {
                a= -1*a;
            }
        }
    }
}
