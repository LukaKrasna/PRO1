using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbarva_Click(object sender, EventArgs e)
        {
            int des =int.Parse(textBox1.Text);
            string dvo = "";
            int i2 =1;
            for (int i = 0; i < i2; i++)
            {
                if (des == 0)
                {
                    break;
                }
                else if (des % 2 == 0)
                {
                    dvo = "0" + dvo;
                    des /= 2;
                }
                else
                {
                    dvo = "1" + dvo;
                    des /= 2;
                }
                i2++;   
            }
            MessageBox.Show("Dvojiško je "+dvo);
        }

        private void btnfont_Click(object sender, EventArgs e)
        {
        }
    }
}
