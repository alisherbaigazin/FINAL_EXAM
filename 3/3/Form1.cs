using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        int c = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = c++;
            Button button = sender as Button;
            button1.Text = n.ToString();
            if (n == 1)
            {
                label1.BackColor = Color.Red;
                label2.BackColor = Color.Black;
                label3.BackColor = Color.Black;
                label4.BackColor = Color.Black;
                label5.BackColor = Color.Black;
                label6.BackColor = Color.Black;
                label7.BackColor = Color.Black;
                label8.BackColor = Color.Black;
                label9.BackColor = Color.Black;
                label10.BackColor = Color.Black;
                label11.BackColor = Color.Black;
                label12.BackColor = Color.Black;
            }
            if (n == 2)
            {
                label1.BackColor = Color.Black;
                label2.BackColor = Color.Red;
                label3.BackColor = Color.Black;
                label4.BackColor = Color.Black;
                label5.BackColor = Color.Black;
                label6.BackColor = Color.Black;
                label7.BackColor = Color.Black;
                label8.BackColor = Color.Black;
                label9.BackColor = Color.Black;
                label10.BackColor = Color.Black;
                label11.BackColor = Color.Black;
                label12.BackColor = Color.Black;
            }
            if (n == 3)
            {
                label1.BackColor = Color.Black;
                label2.BackColor = Color.Black;
                label3.BackColor = Color.Red;
                label4.BackColor = Color.Black;
                label5.BackColor = Color.Black;
                label6.BackColor = Color.Black;
                label7.BackColor = Color.Black;
                label8.BackColor = Color.Black;
                label9.BackColor = Color.Black;
                label10.BackColor = Color.Black;
                label11.BackColor = Color.Black;
                label12.BackColor = Color.Black;

            }
            if (n == 4)
            {
                label1.BackColor = Color.Black;
                label2.BackColor = Color.Black;
                label3.BackColor = Color.Black;
                label4.BackColor = Color.Red;
                label5.BackColor = Color.Black;
                label6.BackColor = Color.Black;
                label7.BackColor = Color.Black;
                label8.BackColor = Color.Black;
                label9.BackColor = Color.Black;
                label10.BackColor = Color.Black;
                label11.BackColor = Color.Black;
                label12.BackColor = Color.Black;
            }
            if (n == 5)
            {
                label1.BackColor = Color.Black;
                label2.BackColor = Color.Black;
                label3.BackColor = Color.Black;
                label4.BackColor = Color.Black;
                label5.BackColor = Color.Red;
                label6.BackColor = Color.Black;
                label7.BackColor = Color.Black;
                label8.BackColor = Color.Black;
                label9.BackColor = Color.Black;
                label10.BackColor = Color.Black;
                label11.BackColor = Color.Black;
                label12.BackColor = Color.Black;
            }
            if (n == 6)
            {
                label1.BackColor = Color.Black;
                label2.BackColor = Color.Black;
                label3.BackColor = Color.Black;
                label4.BackColor = Color.Black;
                label5.BackColor = Color.Black;
                label6.BackColor = Color.Red;
                label7.BackColor = Color.Black;
                label8.BackColor = Color.Black;
                label9.BackColor = Color.Black;
                label10.BackColor = Color.Black;
                label11.BackColor = Color.Black;
                label12.BackColor = Color.Black;
            }
            if (n == 7)
            {
                label1.BackColor = Color.Black;
                label2.BackColor = Color.Black;
                label3.BackColor = Color.Black;
                label4.BackColor = Color.Black;
                label5.BackColor = Color.Black;
                label6.BackColor = Color.Black;
                label7.BackColor = Color.Red;
                label8.BackColor = Color.Black;
                label9.BackColor = Color.Black;
                label10.BackColor = Color.Black;
                label11.BackColor = Color.Black;
                label12.BackColor = Color.Black;
            }
            if (n == 8)
            {
                label1.BackColor = Color.Black;
                label2.BackColor = Color.Black;
                label3.BackColor = Color.Black;
                label4.BackColor = Color.Black;
                label5.BackColor = Color.Black;
                label6.BackColor = Color.Black;
                label7.BackColor = Color.Black;
                label8.BackColor = Color.Red;
                label9.BackColor = Color.Black;
                label10.BackColor = Color.Black;
                label11.BackColor = Color.Black;
                label12.BackColor = Color.Black;
            }
            if (n == 9)
            {
                label1.BackColor = Color.Black;
                label2.BackColor = Color.Black;
                label3.BackColor = Color.Black;
                label4.BackColor = Color.Black;
                label5.BackColor = Color.Black;
                label6.BackColor = Color.Black;
                label7.BackColor = Color.Black;
                label8.BackColor = Color.Black;
                label9.BackColor = Color.Red;
                label10.BackColor = Color.Black;
                label11.BackColor = Color.Black;
                label12.BackColor = Color.Black;

            }
            if (n == 10)
            {
                label1.BackColor = Color.Black;
                label2.BackColor = Color.Black;
                label3.BackColor = Color.Black;
                label4.BackColor = Color.Black;
                label5.BackColor = Color.Black;
                label6.BackColor = Color.Black;
                label7.BackColor = Color.Black;
                label8.BackColor = Color.Black;
                label9.BackColor = Color.Black;
                label10.BackColor = Color.Red;
                label11.BackColor = Color.Black;
                label12.BackColor = Color.Black;
            }
            if (n == 11)
            {
                label1.BackColor = Color.Black;
                label2.BackColor = Color.Black;
                label3.BackColor = Color.Black;
                label4.BackColor = Color.Black;
                label5.BackColor = Color.Black;
                label6.BackColor = Color.Black;
                label7.BackColor = Color.Black;
                label8.BackColor = Color.Black;
                label9.BackColor = Color.Black;
                label10.BackColor = Color.Black;
                label11.BackColor = Color.Red;
                label12.BackColor = Color.Black;
            }
            if (n == 12)
            {
                label1.BackColor = Color.Black;
                label2.BackColor = Color.Black;
                label3.BackColor = Color.Black;
                label4.BackColor = Color.Black;
                label5.BackColor = Color.Black;
                label6.BackColor = Color.Black;
                label7.BackColor = Color.Black;
                label8.BackColor = Color.Black;
                label9.BackColor = Color.Black;
                label10.BackColor = Color.Black;
                label11.BackColor = Color.Black;
                label12.BackColor = Color.Red;
            }

        }
    }
}
