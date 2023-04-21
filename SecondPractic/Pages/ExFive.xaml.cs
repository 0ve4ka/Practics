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
    /// Логика взаимодействия для ExFive.xaml
    /// </summary>
    public partial class ExFive : Page
    {
        public ExFive()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
           

            try
            {
                int year = int.Parse(TbNumA.Text);
                if (year % 100 == 0)
                    Answer.Text = $"Ответ: Номер столетия {year} года равен {year / 100}";
                else
                    Answer.Text = $"Ответ: Номер столетия {year} года равен {year / 100 + 1}";

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
