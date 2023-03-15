using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_ocen_v_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radMat_CheckedChanged(object sender, EventArgs e)
        {
            txtSeminar.Visible = false;
            txtUstna.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            groupBox2.Text = "Študent matematike";
        }

        private void radNar_CheckedChanged(object sender, EventArgs e)
        {
            txtSeminar.Visible = true;
            txtUstna.Visible = false;
            label4.Visible = true;
            label5.Visible = false;
            groupBox2.Text = "Študent naravoslovja";
        }

        private void radAng_CheckedChanged(object sender, EventArgs e)
        {
            txtSeminar.Visible = true;
            txtUstna.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            groupBox2.Text = "Študent angleščine";
        }

        private void btnIzračunaj_Click(object sender, EventArgs e)
        {
            if (radMat.Checked == true)
            {
                try
                {
                    ŠtudentMat m = new ŠtudentMat();
                    m.Delni1 = int.Parse(txtDelni1.Text);
                    m.Delni2 = int.Parse(txtDelni2.Text);
                    labRezultat.Text = m.Izpis();
                }
                catch(Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
            
        }

        private void btnPoenostavi_Click(object sender, EventArgs e)
        {
            txtDelni1.Text = "";
            txtDelni2.Clear();
            txtSeminar.Text = "";
            txtUstna.Text = "";
            labRezultat.Text = "";
        }
    }
}
