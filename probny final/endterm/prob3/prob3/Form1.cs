using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prob3
{
    public partial class Form1 : Form
    {
        Pen p;
        Graphics g;
        int x, y;
        int x1, y1;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            x1 = e.Location.X;
            y1 = e.Location.Y;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            p = new Pen(Color.Black, 2);
            Point[] poi =
            {
                poi(x, y)
            };
            Point[] poi2 =
            {

            };
            g.DrawPolygon(p, poi);
            g.DrawPolygon(p, poi2);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.Location.X;
            y = e.Location.Y;
        }
    }
}
