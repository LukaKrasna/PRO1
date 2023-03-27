using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vajaZaIzpit2
{
    public partial class Form1 : Form
    {
        Knjiga[] knjige=new Knjiga[6];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            knjige[0] = new Knjiga();
            knjige[0].Ime = "Na klancu";
            knjige[0].Avtor = "Ivan Cankar";
            knjige[0].Cena = 12;
            knjige[1] = new Knjiga();
            knjige[1].Ime = "Nekropola";
            knjige[1].Avtor = "Boris Pahoz";
            knjige[1].Cena = 11.5;
            knjige[2] = new Knjiga();
            knjige[2].Ime = "Antigona";
            knjige[2].Avtor = "Sofokles";
            knjige[2].Cena = 13.5;
            listBox1.Items.Clear();
            for(int k = 0; k < 3; k++)
            {
                listBox1.Items.Add(knjige[k].Ime);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string izbrana = listBox1.SelectedItem.ToString();
                for(int k=0;k<3;k++)
                {
                    if(izbrana == knjige[k].Ime)
                    {
                        MessageBox.Show("Izbarl si " + izbrana + "\nAvtor: " + knjige[k].Avtor + "\nCena: " + knjige[k].Cena + "€");
                        break;
                    }
                }
                
            }
        }
    }
}
