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

namespace FourthPractic.Pages
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int N = int.Parse(TbNbNExSix.Text);
                int F = 0;
                int K = 0;

                while (true)
                {
                    F += N % 10;
                    N /= 10;
                    K++;
                    if (N == 0)
                        break;
                }
                Answer.Text = $"Ответ: Сумма цифр {F}; Кол-во цифр {K}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы ввели не корректные данные", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
