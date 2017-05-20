using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final4
{
    public partial class Form1 : Form
    {
        Point y;
        Point x;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            using (Graphics g = panel1.CreateGraphics())
            {
                Pen pen = new Pen(Color.Red, 1);
                SolidBrush sb = new SolidBrush(Color.Red);
               
              
                g.FillEllipse(sb,e.X,e.Y,20,20);
            }
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            y++;

        }
    }
}
