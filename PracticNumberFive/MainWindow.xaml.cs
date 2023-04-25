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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace PracticNumberFive
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

        private void BtnExOne_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(new Pages.ExOnePage());
        }

        private void BtnExTwo_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(new Pages.ExTwoPage());
        }

        private void BtnExThree_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(new Pages.ExThreePage());
        }

        private void BtnExFour_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(new Pages.ExFourPage());
        }

        private void BtnExFive_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(new Pages.ExFivePage());
        }

        private void BtnExSix_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(new Pages.ExSixPage());
        }

        private void BtnExSeven_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(new Pages.ExSevenPage());
        }
    }
}
