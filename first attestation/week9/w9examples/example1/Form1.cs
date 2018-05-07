using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example1
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
            btn.Text = "clik to see time";
            btn.Location = new Point(300, 300);
            //btn.Font = new Font(FontFamily.GenericMonospace, 20);
            btn.Height = 50;
            btn.Width = 100;
            btn.Click += Btn_Click;
            Controls.Add(btn);  
            


            l = new Label();
            l.Text = "the time is";
            l.Location = new Point(200, 300);
            //l.Font = new Font(FontFamily.GenericMonospace, 20);
            l.Height = 50;
            l.Width = 100;
            Controls.Add(l);

            t = new Timer();
            t.Interval = 1000;
            t.Tick += T_Tick;

            
            
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            t.Start();

        }

        private void T_Tick(object sender, EventArgs e)
        {
            l.Text = DateTime.Now.ToLongDateString();
        }
    }
}
