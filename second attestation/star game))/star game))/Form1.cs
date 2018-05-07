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

namespace star_game__
{
    
    public partial class Form1 : Form
    {
        Graphics g;
        Label l = new Label();
        public int w = 100;
        public int h = 90;
        public int r = 30;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            BackColor = Color.Blue;
            l.BackColor = Color.Blue;
            l.Location = new Point(600, 30);
            l.Size = new Size(200, 20);
            Controls.Add(l);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawRectangle(new Pen(Color.Yellow, 4), 600, 30, 202, 20);
            l.ForeColor = Color.Black;
            l.Text = "Level:5, Score:100";
            Point[] hexagon = {
                new Point(315, 165),
                new Point(365, 190),
                new Point(365, 240),
                new Point(315, 265),
                new Point(265, 240),
                new Point(265, 190)
            };
            g.FillPolygon(new SolidBrush(Color.Yellow), hexagon);
            Point[] gun = {
                new Point(300, 216),
                new Point(315, 196),
                new Point(330, 216),

            };
            g.FillPolygon(new SolidBrush(Color.Green), gun);
            g.FillRectangle(new SolidBrush(Color.Green), new Rectangle(308, 216, 14, 20));
            Point[] bullet = {
                new Point(315, 120),
                new Point(310, 130),
                new Point(300, 135),
                new Point(310, 140),
                new Point(315, 150),
                new Point(320, 140),
                new Point(330, 135),
                new Point(320, 130)
            };
            g.FillPolygon(new SolidBrush(Color.Green), bullet);

            g.FillEllipse(new SolidBrush(Color.White), 46, 85, r, r);
            g.FillEllipse(new SolidBrush(Color.White), 285, 60, r, r);
            g.FillEllipse(new SolidBrush(Color.White), 450, 100, r, r);
            g.FillEllipse(new SolidBrush(Color.White), 670, 185, r, r);
            g.FillEllipse(new SolidBrush(Color.White), 60, 350, r, r);
            g.FillEllipse(new SolidBrush(Color.White), 290, 330, r, r);
            g.FillEllipse(new SolidBrush(Color.White), 685, 405, r, r);
            Point[] p1 = {
                new Point(164, 140),
                new Point(188, 182),
                new Point(140, 182)
            };
            Point[] p2 = {
                new Point(140, 154),
                new Point(188, 154),
                new Point(164, 196)
            };
            g.FillPolygon(new SolidBrush(Color.Red), p1);
            g.FillPolygon(new SolidBrush(Color.Red), p2);

            Point[] p3 = {
                new Point(614, 120),
                new Point(638, 162),
                new Point(590, 162)
            };
            Point[] p4 = {
                new Point(590, 134),
                new Point(638, 134),
                new Point(614, 176)
              };
            g.FillPolygon(new SolidBrush(Color.Red), p3);
            g.FillPolygon(new SolidBrush(Color.Red), p4);

            Point[] p5 = {
                new Point(185+24, 265),
                new Point(48+185, 265+42),
                new Point(185, 42+265)
            };
            Point[] p6 = {
                new Point(185, 14+265),
                new Point(185+48, 14+265),
                new Point(24+185, 56+265)
            };
            g.FillPolygon(new SolidBrush(Color.Red), p5);
            g.FillPolygon(new SolidBrush(Color.Red), p6);

            Point[] p7 = {
                new Point(485+24, 335),
                new Point(48+485, 335+42),
                new Point(485, 42+335)
            };
            Point[] p8 = {
                new Point(485, 14+335),
                new Point(485+48, 14+335),
                new Point(24+485, 56+335)
            };

            g.FillPolygon(new SolidBrush(Color.Red), p7);
            g.FillPolygon(new SolidBrush(Color.Red), p8);
        }
    }
}
