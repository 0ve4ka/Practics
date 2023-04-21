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

namespace SecondPractic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Frame.Content = new Pages.ExOne();
        }

       

        private void BtnExOne_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Pages.ExOne());
        }

        private void BtnExTwo_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Pages.ExTwo());
        }

        private void BtnExThree_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Pages.ExThreexaml());
        }

        private void BtnDopOne_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Pages.ExFour());
        }

        private void BtnDopTwoo_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Pages.ExFive());
        }
    }
}
