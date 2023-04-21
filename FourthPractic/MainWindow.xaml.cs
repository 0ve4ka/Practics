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

namespace FourthPractic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Pages.Content = new Pages.ExOnePage();
        }

        private void BtnFirstEx_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate (new Pages.ExOnePage());
        }

        private void BtnSecondtEx_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(new Pages.ExTwoPage());
        }

        private void BtnThirdEx_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(new Pages.ExThreePage());
        }

        private void BtnFourthEx_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(new Pages.ExFourPage());
        }

        private void BtnFivethEx_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(new Pages.ExFivePage());
        }

        private void BtnSixethEx_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(new Pages.ExSixPage());
        }

        private void BtnSeventhEx_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(new Pages.ExSevenPage());
        }

        private void BtnEightEx_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(new Pages.ExEightPage());
        }

        private void BtnNinethEx_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(new Pages.ExNinePage());
        }
    }
}
