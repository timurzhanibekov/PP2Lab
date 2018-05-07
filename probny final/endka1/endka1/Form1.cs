using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace endka1
{
    public partial class Form1 : Form
    {
        List<Button> arr = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button_Click(object sender,EventArgs e)
        {
            Button bt = sender as Button;
            for (int i = 0; i < arr.Count; i++)
            {
                arr[i].BackColor = Color.Green;
            }
            for (int i = 0; i < arr.Count; i++)
            {
                if (bt.Location.X == arr[i].Location.X || bt.Location.Y == arr[i].Location.Y)
                    arr[i].BackColor = Color.Red;
            } 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Button btn = new Button();
                    btn.BackColor = Color.Green;
                    btn.Size = new Size(30, 30);
                    btn.Location = new Point(j * 30 , i * 30 );
                    btn.Click += button_Click;
                    Controls.Add(btn);
                    arr.Add(btn);
                }
            }
        }
    }
}
