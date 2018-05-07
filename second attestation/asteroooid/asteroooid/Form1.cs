using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asteroooid
{
    public partial class Form1 : Form
    {
        int cnt = 0;
        int k = 0;
        int y = 0;
        List<Button> body = new List<Button>(); 
        public Form1()
        {
            InitializeComponent();
            
            timer1.Start();
        }
        bool F()
        {
            int x_1 = button1.Location.X;
            int y_1 = button1.Location.Y;
            int w_1 = button1.Width;
            int h_1 = button1.Height;

            for (int j = 0; j < body.Count; j++)
            {
                int w_h = body[j].Width;
                int a = body[j].Location.X;
                int b = body[j].Location.Y;

                if (a >= x_1 - w_h && a <= x_1 + w_1)
                {
                    if (y_1 == b + h_1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (k % 60 == 0)
            {
                Button btn = new Button();
                Random rdm = new Random();
                btn.Text = "";
                btn.BackColor = Color.Black;
                int x = rdm.Next(0, Width - 40);
                btn.Size = new Size(30, 30);
                btn.Location = new Point(x, y);
                label1.Text = cnt.ToString();
                Controls.Add(btn);
                body.Add(btn);
            }
            if (F())
            {
                timer1.Stop();
                MessageBox.Show("Game Over" + "Your Score - " + cnt.ToString());
            }
            else
            {
                for (int i = 0; i < body.Count; i++)
                {
                    int a = body[i].Location.X;
                    int b = body[i].Location.Y;
                    b++;
                    if (b <= Height - 55)
                    {
                        body[i].Location = new Point(a, b);
                    }
                    else
                    {
                        cnt++;
                        Button btr = body[i];
                        body.Remove(btr);
                        this.Controls.Remove(btr);
                    }
                }
            }
            k++;
        }

        private void sdfgs(object sender, KeyEventArgs e)
        {
                
        }

        private void downkey(object sender, KeyEventArgs e)
        {
            int n = 0;
            int m = 0;
            if (e.KeyCode == Keys.D)
            {
                n = button1.Location.X;
                m = button1.Location.Y;
                n += 10;
                button1.Location = new Point(n, m);
            }
            if (e.KeyCode == Keys.A)
            {
                n = button1.Location.X;
                m = button1.Location.Y;
                n -= 10;
                button1.Location = new Point(n, m);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
