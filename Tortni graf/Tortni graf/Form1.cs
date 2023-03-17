using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tortni_graf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Element[] el = new Element[5];
            el[0] = new Element("Vzhod", 50.75);
            el[1] = new Element("Zahod", 22);
            el[2] = new Element("Sever", 72.32);
            el[3] = new Element("Jug", 12);
            el[4] = new Element("Center", 44);
            Graphics g = e.Graphics;
            double vsota = 0;
            for(int k = 0; k < el.Length; k++)
            {
                vsota += el[k].prodaja;
            }
            Pen p = new Pen(Color.Black);
            Color[] barve = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo };
            Rectangle r = new Rectangle(1, 1, pictureBox1.Width- 2, pictureBox1.Height- 2);
            g.SmoothingMode = SmoothingMode.HighQuality;
            float začetniKot = 0;
            for(int i=0; i < el.Length; i++)
            {
                float kot = (float)(el[i].prodaja * 360 / vsota);
                Brush br = new SolidBrush(barve[i]);
                g.FillPie(br, r, začetniKot, kot);
                g.DrawPie(p, r, začetniKot, kot);
                g.DrawString("Vzhod", new Font("Ariel",10),new SolidBrush(Color.Black),new Rectangle(0,0,100,100));
                začetniKot += kot;
            }
        }
    }
}
