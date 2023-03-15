using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minolovec_v_WFA
{
    public partial class Form1 : Form
    {
        LogikaIgre a = new LogikaIgre();
        Button[,] x = new Button[10 + 2, 10 + 2];
        public Form1()
        {
            InitializeComponent();
            for(int k=1;k<=10;k++)
            {
                for(int j=1;j<=10;j++)
                {
                    x[k, j] = new Button();
                    x[k, j].Size = new Size(30, 30);
                    if (a.mine[k, j] == true)
                    {
                        x[k, j].Text = "*";
                    }
                    else
                    {
                        x[k, j].Text = a.rešitev[k, j] + " ";
                    }
                    x[k, j].ForeColor = SystemColors.ButtonFace;
                    fp.Controls.Add(x[k, j]);
                    x[k, j].Click += new EventHandler(Prikaži);
                    x[k, j].MouseUp += new MouseEventHandler(Zastavica);
                }
            }
        }

        private void Zastavica(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button b = (Button)sender;
                b.ForeColor = Color.Black;
                b.Text = "|>";
            }
        }

        private void Prikaži(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "*")
                MessageBox.Show("Konec igre!");
            else
            {
                b.ForeColor = Color.Black;
            }
        }
    }
}
