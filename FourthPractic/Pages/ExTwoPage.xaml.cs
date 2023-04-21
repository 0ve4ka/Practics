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
    /// Логика взаимодействия для ExTwoPage.xaml
    /// </summary>
    public partial class ExTwoPage : Page
    {
        public ExTwoPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int F = int.Parse(TbNbNExTwo.Text);
                if (F >= 20 && F <= 69)
                {
                    switch (F % 10)
                    {
                        case 0:
                            Answer.Text = $"{F} лет";
                            break;
                        case 1:
                            Answer.Text = $"{F} год";
                            break;
                        case 2:
                            Answer.Text = $"{F} года";
                            break;
                        case 3:
                            Answer.Text = $"{F} года";
                            break;
                        case 4:
                            Answer.Text = $"{F} года";
                            break;
                        case 5:
                            Answer.Text = $"{F} лет";
                            break;
                        case 6:
                            Answer.Text = $"{F} лет";
                            break;
                        case 7:
                            Answer.Text = $"{F} лет";
                            break;
                        case 8:
                            Answer.Text = $"{F} лет";
                            break;
                        case 9:
                            Answer.Text = $"{F} лет";
                            break;
                    }

                }
                else
                    Answer.Text = "Нужно число в диапазоне 20-69";
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
