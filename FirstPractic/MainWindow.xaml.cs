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

namespace FirstPractic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Pages.Content = new ListPages.ExerciseOne();
        }

        

        private void BtnGoExOne_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate (new ListPages.ExerciseOne());
        }

        private void BtnGoExTwo_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(new ListPages.ExerciseTwo());
        }

        private void BtnGoExthree_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(new ListPages.ExerciseThree());
        }

        private void BtnGoExFour_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(new ListPages.ExerciseFour());
        }

        private void BtnGoExFive_Click(object sender, RoutedEventArgs e)
        {
            Pages.Navigate(new ListPages.ExerciseFive());
        }
    }
}
