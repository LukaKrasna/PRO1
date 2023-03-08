using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prva_aplikacija
{
    public partial class Form1 : Form
    {
        int števec = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            labNapis.Text = "Kliknil si na gumb.";
        }

        private void Štej(object sender, EventArgs e)
        {
            števec++;
            labŠtevec.Text = "Kliknil si " + števec + "-krat.";
        }
    }
}
