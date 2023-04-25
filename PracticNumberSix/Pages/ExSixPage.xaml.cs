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

namespace PracticNumberSix.Pages
{
    /// <summary>
    /// Логика взаимодействия для ExSixPage.xaml
    /// </summary>
    public partial class ExSixPage : Page
    {
        public ExSixPage()
        {
            InitializeComponent();
        }
       public static string Fib(int n)
        {
            string Result = "0, ";
            int F = 0;
            int S = 1;
            for (int i = 2; i <= n; i++)
            {
                S += F;
                F = S - F;
                Result += $"{F}, ";
            }
            return Result;
        }
        private void BtnExSix_Click(object sender, RoutedEventArgs e)
        {
           
            try
            {
                int N = int.Parse(TbNbExSix.Text);

                Answer.Text = $"{Fib(N)}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
