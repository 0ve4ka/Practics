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
    /// Логика взаимодействия для ExFivePage.xaml
    /// </summary>
    public partial class ExFivePage : Page
    {
        public ExFivePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            try
            {
                float P = Single.Parse(TbNbPExFive.Text);
                float S = 10;
                int K = 0;
                bool b = true;
                float F;
                if (P > 0 && P < 50)
                {
                while (b)
                    {
                        if (S > 200)
                            b = false;
                        else
                        {
                            F = P / 100 * S;
                            S += F;
                            K++;
                        }
                    }
                    Answer.Text = $"Кол-во дней {K}; кол-во километров {S:F2} ";
                }
                else
                    Answer.Text = "Нужно значение P в диапазоне (0,50)";
                
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
