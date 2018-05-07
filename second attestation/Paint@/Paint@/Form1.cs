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

namespace Paint_
{
    public enum Tool
    {
        Pen,
        Line,
        rectangle,
        circle,
        eraser, 
        triangle,
        star,
        stain
    }
    public partial class Form1 : Form
    {
        Queue<Point> q = new Queue<Point>();
        Graphics g;
        Pen pen;
        Bitmap bmp;
        Point prev, cur;
        Tool t;
        GraphicsPath path;
        Color c;
        Color fill;
        int n = 1;
        
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            fill = colorDialog1.Color;
            t = Tool.Pen;
            path = new GraphicsPath();
            c = Color.Black;
        }

        public void Check(int x, int y)
        {
            if (x < 0 || y < 0 || x >= pictureBox1.Width || y >= pictureBox1.Height)
                return;
            if (bmp.GetPixel(x, y) == c)
            {
                bmp.SetPixel(x, y, fill);
                q.Enqueue(new Point(x, y));
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cur = e.Location;
                path.Reset();
                Point location = new Point();
                Size size = new Size(Math.Abs(prev.X - cur.X), Math.Abs(prev.Y - cur.Y));
                if (cur.X < prev.X && cur.Y < prev.Y)
                    {
                    location = cur;
                    }
                if (cur.X < prev.X && cur.Y > prev.Y)
                {
                    location = new Point(cur.X, prev.Y);
                }
                if (cur.X > prev.X && cur.Y < prev.Y)
                {
                    location = new Point(prev.X, cur.Y);
                }
                if (cur.X > prev.X && cur.Y > prev.Y)
                {
                    location = prev;
                }
                if (t == Tool.Pen)
                {
                    g.DrawLine(pen, prev, cur);
                    prev = cur;
                }
                if (t == Tool.Line)
                {
                    path.AddLine(prev, cur);
                }
                if (t == Tool.rectangle)
                {
                    path.AddRectangle(new Rectangle(location, size));
                }
                if (t == Tool.circle)
                {
                    path.AddEllipse(new Rectangle(location, size));
                }
                if (t == Tool.eraser)
                {
                    g.DrawLine(new Pen(Color.White, 5), prev, cur);
                    prev = cur;
                }
                if (t == Tool.triangle)
                {
                    Point point1 = new Point(prev.X, prev.Y);
                    Point point2 = new Point(cur.X, cur.Y);
                    Point point3 = new Point(prev.X - (cur.X - prev.X), cur.Y);
                    Point[] pp =
                    {
                        point1,
                        point2,
                        point3
                    };
                    path.AddPolygon(pp);
                }
                if (t == Tool.star)
                {
                    Point point1 = new Point(prev.X, prev.Y);
                    Point point2 = new Point(cur.X, cur.Y);
                    Point point3 = new Point(prev.X - (cur.X - prev.X), cur.Y);
                    Point point4 = new Point(prev.X, cur.Y + cur.Y*1/3);
                    Point point5 = new Point(cur.X, cur.Y*1/3);
                    Point point6 = new Point(prev.X - (cur.X - prev.X), cur.Y*1/3);
                    Point[] p1 =
                    {
                        point1,
                        point2,
                        point3,
                    };
                    Point[] p2 =
                    {
                        point4,
                        point5,
                        point3
                    };
                    path.AddPolygon(p1);
                    path.AddPolygon(p2);
                }
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            g.DrawPath(pen, path);
        }

        private void Line_Click(object sender, EventArgs e)
        {
            t = Tool.Line;
        }

        private void penn_MouseClick(object sender, MouseEventArgs e)
        {
            t = Tool.Pen;
        }
        private void rectangle_Click(object sender, EventArgs e)
        {
            t = Tool.rectangle;
        }
        private void circle_Click(object sender, EventArgs e)
        {
            t = Tool.circle;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            pen = new Pen(c, n);
            if (path != null)
            {
                e.Graphics.DrawPath(pen, path); 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            t = Tool.eraser;
        }

        private void triangle_Click(object sender, EventArgs e)
        {
            t = Tool.triangle;
        }

        private void changesize_Click(object sender, EventArgs e)
        {
            n = int.Parse(textBox1.Text);
        }

        private void color_Click(object sender, EventArgs e)
        {
            //colorDialog1.ShowDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                fill = colorDialog1.Color;
                c = colorDialog1.Color;
            }
        }

        private void star_Click(object sender, EventArgs e)
        {
            t = Tool.star;
        }

        private void stain_Click(object sender, EventArgs e)
        {
            t = Tool.stain;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.Filter = "PNG (*.png)|*.png|JPEG (*.jpg;*.jpeg)|*.jpg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(pictureBox1.Width);
                int height = Convert.ToInt32(pictureBox1.Height);
                Bitmap bmp = new Bitmap(width, height);
                pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(saveFileDialog1.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG (*.png)|*.png*|JPEG (*.jpg;*.jpeg)|*.jpg*|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 3;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prev = e.Location;
            if (t == Tool.stain)
            {
                int x = e.X;
                int y = e.Y;
                c = bmp.GetPixel(x, y);
                q.Enqueue(new Point(x, y));
                bmp.SetPixel(x, y, fill);
                while (q.Count > 0)
                {
                    Point p = q.Dequeue();
                    Check(p.X - 1, p.Y);
                    Check(p.X + 1, p.Y);
                    Check(p.X, p.Y - 1);
                    Check(p.X, p.Y + 1);
                }
                pictureBox1.Refresh();
            }
        }
    }
}
