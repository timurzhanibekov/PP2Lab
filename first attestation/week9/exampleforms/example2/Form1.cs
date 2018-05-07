using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example2
{

    public partial class Form1 : Form
    {
        Label l;
        Timer t;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "to start";
            btn.Location = new Point(50, 40);
            btn.Font = new Font(FontFamily.GenericMonospace, 10);
            btn.Width = 50;
            btn.Height = 100;
            btn.BackColor = Color.Gold;
            btn.Click += Btn_Click;

            l = new Label();
            l.Text = "my text";
            l.Location = new Point(100, 150);
            l.Font = new Font(FontFamily.GenericMonospace, 10);
            l.Height = 100;
            l.Width = 50;

            t = new Timer();
            t.Interval = 1000;
            t.Tick += T_Tick;

            Controls.Add(l);
            Controls.Add(btn);
        }

        private void T_Tick(object sender, EventArgs e)
        {
            l.Text = DateTime.Now.ToLongDateString();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            t.Start();
        }
    }
}
