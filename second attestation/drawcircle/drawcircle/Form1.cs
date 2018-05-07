using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawcircle
{
    public partial class Form1 : Form
    {
        int a=100, b=100;
        Pen p;
        Graphics g;
        int l = 2;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.DrawRectangle(new Pen(Color.Red,3), a - l, b - l, 2*l, 2*l);
            l += 10;
            
        }

        private void circle(object sender, MouseEventArgs e)
        {
            l = 2;
            a = e.Location.X;
            b = e.Location.Y;
            timer1.Enabled = true;
        }
    }
}
