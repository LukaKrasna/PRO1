using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rdusd.Checked = true;
            lblrez.Text = "USD";
        }


        private void btnizhod_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnpočisti_Click(object sender, EventArgs e)
        {
            txtrez.Text = "";
            TXTVNOS.Text = "";

        }

        private void RDCHF_CheckedChanged(object sender, EventArgs e)
        {
            lblrez.Text = "CHF";
        }

        private void rdgbp_CheckedChanged(object sender, EventArgs e)
        {
            lblrez.Text = "GBP";
        }

        private void rdusd_CheckedChanged(object sender, EventArgs e)
        {
            lblrez.Text = "USD";
        }

        private void btniračun_Click(object sender, EventArgs e)
        {
            Double vnos = double.Parse(TXTVNOS.Text);
            if (rdusd.Checked == true)
            {
                txtrez.Text = (vnos * 0.94).ToString();
            }
            if (RDCHF.Checked==true)
            {
                txtrez.Text = (vnos * 0.99).ToString();
            }
            if (rdgbp.Checked == true)
            {
                txtrez.Text = (vnos * 0.88).ToString();
            }
        }
    }
}
