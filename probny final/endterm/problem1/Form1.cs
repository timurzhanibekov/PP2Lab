using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problem1
{
    public partial class Form1 : Form
    {
        int n = 0;
        string s = "";
        string k = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            s = menuStrip1.Text;
            //label1.Font = new Font(FontFamily, )
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            n = trackBar1.Value + 50;
            label1.Location = new Point(n, label1.Location.Y);
        }


    }
}
