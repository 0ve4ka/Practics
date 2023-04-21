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
    /// Логика взаимодействия для ExSevenPage.xaml
    /// </summary>
    public partial class ExSevenPage : Page
    {
        public ExSevenPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                int F = int.Parse(TbNbNExSeven.Text);                                      
                if (F >= 10 && F <= 40)
                    if (F > 10 && F < 20 )
                        Answer.Text = $"{F} учебных заданий";
                    else
                        switch (F%10)
                        {
                            case 1:
                                Answer.Text = $"{F} учебное задание";
                                break;
                            case 2:
                                Answer.Text = $"{F} учебных задания";
                                break;
                            case 3:
                                Answer.Text = $"{F} учебных задания";
                                break;
                            case 4:
                                Answer.Text = $"{F} учебных задания";
                                break;
                            case 5:
                                Answer.Text = $"{F} учебных заданий";
                                break;
                            case 6:
                                Answer.Text = $"{F} учебных заданий";
                                break;
                            case 7:
                                Answer.Text = $"{F} учебных задания";
                                break;
                            case 8:
                                Answer.Text = $"{F} учебных задания";
                                break;
                            case 9:
                                Answer.Text = $"{F} учебных задания";
                                break;
                            default:
                                Answer.Text = $"{F} учебных заданий";
                                break;
                        }
                else
                    Answer.Text = "Нужно число в диапазоне [10-40]";
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
