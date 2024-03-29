﻿using System;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Napadnazemljo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random r = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void prgIgra_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void btnstart_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DodajSovražnika()
        {
            ContentControl sovražnik = new ContentControl();
            sovražnik.Template = Resources["predlogaSovražnik"] as ControlTemplate;
            AnimirajSovražnika(sovražnik, 0, (int)(igralniDel.ActualWidth) - 199, "(Canvas.Left)");
            int višina = (int)(igralniDel.ActualHeight - 100);
            AnimirajSovražnika(sovražnik, r.Next(višina), r.Next(višina), "(Canvas.Top)");
            igralniDel.Children.Add(sovražnik);
        }
        private void AnimirajSovražnika(ContentControl sovražnik, int v1, int v2, string v3)
        {
            Storyboard zgodba = new Storyboard
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };
            DoubleAnimation animacija = new DoubleAnimation()
            {
                From = v1,
                To = v2,
                Duration = new Duration(TimeSpan.FromSeconds(r.Next(4, 6)))
            };
            PropertyPath x = new PropertyPath(v3);
            Storyboard.SetTarget(animacija, sovražnik);
            Storyboard.SetTargetProperty(animacija, x);
            zgodba.Children.Add(animacija);
            zgodba.Begin();
        }

        private void btnstart_Click_1(object sender, RoutedEventArgs e)
        {
            DodajSovražnika();
        }
    }
}
