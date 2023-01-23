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

namespace Napadnazemljo
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

        private void prgIgra_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            DodajSovražnika();
        }

        private void DodajSovražnika()
        {
            ContentControl sovražnik = new ContentControl();
            sovražnik.Template = Resources["btnStart"] as ControlTemplate;
            AnimirajSovražnika(sovražnik, 0, (int)IgralniDel.ActualWidth - 199), "(Can)"
        }
    }
}
