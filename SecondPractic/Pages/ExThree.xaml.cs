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

namespace SecondPractic.Pages
{
    /// <summary>
    /// Логика взаимодействия для ExThreexaml.xaml
    /// </summary>
    public partial class ExThreexaml : Page
    {
        public ExThreexaml()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                string[] days = { "Воскресенье", "Понедельник","Вотрник","Среда","Четверг","Пятница","Суббота"};
                int K = int.Parse(TbNumK.Text);
                int F = K;
                if (K >= 1 && K <= 365)
                {
                    F = (F + 3) % 7;
                    Answer.Text = $"Ответ: День номер {K} соответствует {F} дню недели, т.е {days[F]}";
                }
                else
                {
                    MessageBox.Show("Вы ввели слишком большое число", "Ошибка");
                }

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
