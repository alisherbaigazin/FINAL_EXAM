using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final2
{
    public partial class Form1 : Form
    {
        int a = 1;
        int t = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            int n = a++;
            Button button = sender as Button;
            button.Text = n.ToString();
            textBox1.Text = n.ToString();
            if (n % 2!=0)
            {
                t++;
                
            }
            textBox1.Text = t.ToString();


        }
    }
}
