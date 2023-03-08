using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enostaven
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIzračunajKlik(object sender, EventArgs e)
        {
            int a = int.Parse(txtPrvo.Text);
            int b = int.Parse(txtDrugo.Text);
            int c = 0;
            if (radPlus.Checked)
                c = a + b;
            if (radMinus.Checked)
                c = a - b;
            if (radKrat.Checked)
                c = a * b;
            if (radDeljeno.Checked)
                c = a / b;
            rezultat.Text = c + "";
        }

        private void btnPočisti_Click(object sender, EventArgs e)
        {
            txtPrvo.Text = "";
            txtDrugo.Text = "";
            rezultat.Clear();//je isto kot zgoraj
            //ponastavi se v prvi textbox
            txtPrvo.Focus();
        }

        private void radPlus_Click(object sender, EventArgs e)
        {
            txtPrvo.Focus();
        }

        private void radMinus_Click(object sender, EventArgs e)
        {
            txtPrvo.Focus();
        }

        private void radKrat_CheckedChanged(object sender, EventArgs e)
        {
            txtPrvo.Focus();
        }

        private void radDeljeno_CheckedChanged(object sender, EventArgs e)
        {
            txtPrvo.Focus();
        }
    }
}
