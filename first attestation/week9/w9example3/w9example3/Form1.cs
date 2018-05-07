using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w9example3
{
    public partial class Form1 : Form
    {
        Timer t;
        Label l;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (s.Contains('a'))
            {
                MessageBox.Show("true");
            }
            else
            {
                MessageBox.Show("false");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Green;
            Button time = new Button();
            time.Text = "to know time";
            time.Location = new Point(200, 200);
            time.Height = 20;
            time.Width = 50;
            time.Font = new Font(FontFamily.GenericSansSerif, 10);
            time.Click += Time_Click;

            l = new Label();
            l.Text = "?";
            l.Location = new Point(170, 200);
            l.Width = 50;
            l.Height = 20;

            Controls.Add(l);
            Controls.Add(time);
            
        }

        private void Time_Click(object sender, EventArgs e)
        {
            l.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
