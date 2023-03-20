using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testnaslika
{
    public partial class Form1 : Form
    {
        Bitmap original = new Bitmap("D:\\PRO1sk11\\Testnaslika.png");
        public Form1()
        {

            InitializeComponent();
        }

        private void btnOdpri_Click(object sender, EventArgs e)
        {
            DialogResult a = openFileDialog1.ShowDialog();
            if (a != DialogResult.OK)
                return;
            string imeDatoteke = openFileDialog1.FileName;
            original = new Bitmap(imeDatoteke);
            pictureBox1.Image = original;
            PosodobiSliko();

        }
        public void NastaviDrsnike()
        {
            if (pictureBox1.Width > original.Width)
                hScrollBar1.Visible = false;
            else
            {
                hScrollBar1.Visible = true;
                hScrollBar1.Maximum = original.Width - pictureBox1.Width;
            }
            if (pictureBox1.Height > original.Height)
                vScrollBar1.Visible = false;
            else
            {
                vScrollBar1.Visible = true;
                vScrollBar1.Maximum = original.Height - pictureBox1.Height;
            }
        }
        public void PosodobiSliko()
        {
            NastaviDrsnike();
            Graphics g = pictureBox1.CreateGraphics();
            Rectangle p1 = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
            Rectangle p2 = new Rectangle(hScrollBar1.Value, vScrollBar1.Value, pictureBox1.Width, pictureBox1.Height);
            g.DrawImage(original, p1, p2, GraphicsUnit.Pixel);
            pictureBox1.Update();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            PosodobiSliko();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            PosodobiSliko();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            PosodobiSliko();
        }

        private void zrcaliNavpičnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int x=0; x < original.Width/2;x++)
            {
                for(int y=0; y<original.Height;y++)
                {
                    Color barva = original.GetPixel(x, y);
                    original.SetPixel(original.Width - x - 1, y, barva);
                }
                PosodobiSliko();
            }
        }

        private void zrcaliVodoravnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height / 2; y++)
                {
                    Color barva = original.GetPixel(x, y);
                    original.SetPixel(x,original.Height - y - 1, barva);
                }
                PosodobiSliko();
            }
        }

        private void negativToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int x=0; x <original.Width; x++)
            {
                for(int y = 0; y < original.Height; y++)
                {
                    Color barva = original.GetPixel(x, y);
                    int r = 255 - barva.R;
                    int g = 255 - barva.G;
                    int b = 255 - barva.B;
                    barva = Color.FromArgb(r, g, b);
                    original.SetPixel(x, y, barva);
                }
                PosodobiSliko();
            }
        }

        private void vrtenjeZa90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            original.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = original;
            PosodobiSliko();
        }
    }
}
