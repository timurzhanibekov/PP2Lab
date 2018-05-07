using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace probelm10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void change(object sender, ScrollEventArgs e)
        {   int n = vScrollBar1.Value;
            label1.Location = new Point(70, n);
        }
    }
}
