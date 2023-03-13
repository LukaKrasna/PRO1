using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_vaja_za_izpit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIzračun_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtVnos.Text);
            double USD = 1.07;
            double JPY = 142.82;
            double GBP = 0.88;
            double b = 0;
            if (radUSD.Checked)
                lblRezultat.Text = "USD";
                b = a * USD;
            if (radJPY.Checked)
                lblRezultat.Text = "JPY";
                b = a * JPY;
            if (radGBP.Checked)
                lblRezultat.Text = "GBP";
                b = a * GBP;
            txtRezultat.Text = b + "";
        }

        private void btnIzbriši_Click(object sender, EventArgs e)
        {
            txtVnos.Clear();
            txtRezultat.Clear();
            txtVnos.Focus();
        }
    }
}
