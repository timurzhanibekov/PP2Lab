using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star_game
{
    public partial class Form1 : Form
    {
        Point G = new Point(500, 300);
        Point B = new Point(500, 100);
        Point[] directions =
        {
            new Point(2, 10),
            new Point(-2, 8),
            new Point(-6, -9),
            new Point(2, 1),
            new Point(-10, 6),
            new Point(-5, -1)
        };
        Point[] stars =
        {
            new Point(50, 90),
            new Point(600, 500),
            new Point(800, 250),
            new Point(300, 100),
            new Point(100, 600),
            new Point(500, 200)
        };
        Point[] asteroids =
        {
            new Point(250, 190),
            new Point(150, 500),
            new Point(700, 50),
            new Point(350, 400),
            new Point(50, 650),
            new Point(450, 250)
        };
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            
        }

        private void Drawbullet(int x, int y)
        {
            int s = 100;
            Point[] p =
            {
                new Point(x, y - s/2),
                new Point(x - s/8, y -s/8),
                new Point(x - s/2, y),
                new Point(x - s/8, y + s/8),
                new Point(x, y + s/2),
                new Point(x + s/8, y + s/8),
                new Point(x + s/2, y),
                new Point(x + s/8, y - s/8)
            };
            SolidBrush brush = new SolidBrush(Color.LightGreen);
            g.FillPolygon(brush, p);
        }
        
        private void Drawgun(int x, int y)
        {
            int s = 100;
            Point[] p1 =
            {
                new Point(x, y - s/2),
                new Point(x - s/2, y - s/4),
                new Point(x - s/2, y + s/4),
                new Point(x, y + s/2),
                new Point(x + s/2, y + s/4),
                new Point(x + s/2, y - s/4)
            };
            Point[] p2 =
            {
                new Point(x, y - s/4),
                new Point(x - s/8, y),
                new Point(x - s/16, y),
                new Point(x - s/16, y + s/4),
                new Point(x + s/16, y + s/4),
                new Point(x + s/16, y),
                new Point(x + s/8, y)
            };
            SolidBrush brush1 = new SolidBrush(Color.Yellow);
            SolidBrush brush2 = new SolidBrush(Color.Green);
            g.FillPolygon(brush1, p1);
            g.FillPolygon(brush2, p2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
