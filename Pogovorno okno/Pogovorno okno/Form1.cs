using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pogovorno_okno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //DialogResult odg = dlgBarva.ShowDialog();
            //if(odg == DialogResult.OK)
            //txtVnos.ForeColor = dlgBarva.Color;
        }

        private void btnBarva_Click(object sender, EventArgs e)
        {
            DialogResult odg = dlgBarva.ShowDialog();
            if (odg == DialogResult.OK)
            txtVnos.ForeColor = dlgBarva.Color;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            DialogResult odg = dlgBarva.ShowDialog();
            if (odg == DialogResult.OK)
                txtVnos.ForeFont = dlgFont.Color;
        }
    }
}
