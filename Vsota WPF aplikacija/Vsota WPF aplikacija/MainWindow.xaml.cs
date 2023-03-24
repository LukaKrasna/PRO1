using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vsota_WPF_aplikacija
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnIzračunaj_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(txtPrvoŠtevilo.Text);
            int b = int.Parse(txtDrugoŠtevilo.Text);
            int c = 0;
            if (radSeš.IsChecked==true)
                c = a + b;
            if (radOdš.IsChecked==true)
                c = a - b;
            if (radMno.IsChecked==true)
                c = a * b;
            if (radDel.IsChecked==true)
                c = a / b;
            txtRezultat.Text = c + "";
        }

        private void btnPočisti_Click(object sender, RoutedEventArgs e)
        {
            txtPrvoŠtevilo.Clear();
            txtDrugoŠtevilo.Clear();
            txtRezultat.Clear();
            radSeš.Focus();
        }

        private void radSeš_Checked(object sender, RoutedEventArgs e)
        {
            txtPrvoŠtevilo.Focus();
        }

        private void radOdš_Checked(object sender, RoutedEventArgs e)
        {
            txtPrvoŠtevilo.Focus();
        }

        private void radMno_Checked(object sender, RoutedEventArgs e)
        {
            txtPrvoŠtevilo.Focus();
        }

        private void radDel_Checked(object sender, RoutedEventArgs e)
        {
            txtPrvoŠtevilo.Focus();
        }
    }
}
