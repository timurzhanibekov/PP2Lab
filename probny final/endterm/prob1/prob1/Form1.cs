using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prob1
{
    public partial class Form1 : Form
    {
        int n = 0;
        int m = 0;
        string s = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            n = trackBar1.Value;
            label1.Location = new Point(n, label1.Location.Y);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            s = textBox1.Text;
            //label1.Font = new Font(FontFamily, c)
        }
    }
}
