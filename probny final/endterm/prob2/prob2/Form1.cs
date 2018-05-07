using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prob2
{
    public partial class Form1 : Form
    {
        Point location;
        Size size;
        Pen p;
        Graphics g;
        int x, y;
        int dy = 5;
        bool f;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            f = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //location = e.Location;
            x = e.Location.X;
            y = e.Location.Y;
            f = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //size = new Size(30, 30);
            //g.Clear(Color.White);
            p = new Pen(Color.Red, 5);
            if (e.Button == MouseButtons.Left)
            {
                g.DrawEllipse(p, new Rectangle(x, y + dy , 30, 30));
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
           /* if (f)
            {
                g.DrawEllipse(p, new Rectangle(x, y + dy, 30, 30));
            }*/
            dy += 5;
        }
    }
}
