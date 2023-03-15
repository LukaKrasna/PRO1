using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Risanje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Blue, 3);
            //g.DrawLine(p, 100, 100, 200, 200);
            Brush br = new SolidBrush(Color.LightBlue);
            g.FillEllipse(br, 100, 100, 250, 250);
            g.DrawEllipse(p, 100, 100, 250, 250);
            p = new Pen(Color.Green, 3);
            br = new SolidBrush(Color.LightGreen);
            g.FillRectangle(br, 350, 100, 250, 250);
            g.DrawRectangle(p, 350, 100,250,250);
        }
    }
}
