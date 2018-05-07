using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problem
{
    public partial class Autorization : Form
    {
        
        public Autorization()
        {
            InitializeComponent();
        }

        private void Autorization_Load(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == '@')
                {
                    MessageBox.Show("Hello");
                    return ;
                }
            }
            MessageBox.Show("your email is wrong");

            
        }
    }
}
