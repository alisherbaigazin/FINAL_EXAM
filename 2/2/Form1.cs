using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        int b1 = 1;
        int b2 = 1;
        int b3 = 1;
        int b4 = 1;
        int b5 = 1;
        int b6 = 1;
        int b7 = 1;
        int b8 = 1;
        int b9 = 1;
        int t = 0;
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            int n = b1++;
            Button button = sender as Button;
            button1.Text = n.ToString();
            if(n % 2 != 0 && n != 1)
                {
                t++;
                textBox1.Text = t.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = b2++;
            Button button = sender as Button;
            button2.Text = n.ToString();
            if (n % 2 != 0 && n != 1)
            {
                t++;
                textBox1.Text = t.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = b3++;
            Button button = sender as Button;
            button3.Text = n.ToString();
            if (n % 2 != 0 && n != 1)
            {
                t++;
                textBox1.Text = t.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = b4++;
            Button button = sender as Button;
            button4.Text = n.ToString();
            if (n % 2 != 0 && n != 1)
            {
                t++;
                textBox1.Text = t.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n = b5++;
            Button button = sender as Button;
            button5.Text = n.ToString();
            if (n % 2 != 0 && n != 1)
            {
                t++;
                textBox1.Text = t.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int n = b6++;
            Button button = sender as Button;
            button6.Text = n.ToString();
            if (n % 2 != 0 && n != 1)
            {
                t++;
                textBox1.Text = t.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int n = b7++;
            Button button = sender as Button;
            button7.Text = n.ToString();
            if (n % 2 != 0 && n != 1)
            {
                t++;
                textBox1.Text = t.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int n = b8++;
            Button button = sender as Button;
            button8.Text = n.ToString();
            if (n % 2 != 0 && n != 1)
            {
                t++;
                textBox1.Text = t.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int n = b9++;
            Button button = sender as Button;
            button9.Text = n.ToString();
            
              if (n % 2 != 0 && n != 1)
            {
                t++;
                textBox1.Text = t.ToString();
            }
        }
        
            
        
    }
}
