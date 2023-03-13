using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFromsApp_vaja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKvadrat_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtStranica.Text);
            int obseg = 4 * a;
            int ploščina = a * a;
            txtObsegKv.Text = obseg + "";
            txtPloščinaKv.Text = ploščina + "";
        }

        private void btnKrog_Click(object sender, EventArgs e)
        {
            int b = int.Parse(txtPolmer.Text);
            double obsegKrog = 2 * Math.PI * b;
            double ploščinaKrog = Math.PI * (b * b);
            txtObsegKrog.Text = String.Format("{0:0.00}", obsegKrog);
            txtPloKrog.Text = String.Format("{0:0.00}", ploščinaKrog);
        }
    }
}
