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


namespace PracticNumberFive.Pages
{
    /// <summary>
    /// Логика взаимодействия для ExFourPage.xaml
    /// </summary>
    public partial class ExFourPage : Page
    {
        public ExFourPage()
        {
            InitializeComponent();
        }

        private void BtnExFour_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int N = int.Parse(TBoxNbN.Text);
                float X = Single.Parse(TBoxNbX.Text);
                if (Math.Abs(X)<1 && N > 0)
                {
                    double Result = X;
                    for (int i = 0; i < N; i++)
                    {
                        Result += Math.Pow(-1, N) * Math.Pow(X, 2 * N + 1) / (2 * N + 1);
                    }
                    Answer.Text = $"Ответ: {Result:F4}";
                }
               else
                    MessageBox.Show("Нужно ввести число |Х|<1 или(и) число N > 0", "Ошибка");
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
