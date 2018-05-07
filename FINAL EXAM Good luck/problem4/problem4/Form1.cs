using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problem4
{
    public partial class Form1 : Form
    {
        int dy = 0;
        Graphics g;
        Pen pen;
        Random rdm;
        Point location, size;
        GraphicsPath path;
        public Form1()
        {
            g = CreateGraphics();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            dy += 2;
            pen = new Pen(Color.Black, 2);
            //rdm = Location.X; 
            g.DrawEllipse(pen, new Rectangle(50, dy + 10, 40, 40));
        }
    }
}
