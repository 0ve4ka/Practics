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
    /// Логика взаимодействия для ExFour.xaml
    /// </summary>
    public partial class ExFour : Page
    {
        public ExFour()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = int.Parse(TbNumA.Text);
                int B = int.Parse(TbNumB.Text);
                int C = int.Parse(TbNumC.Text);

                int Triangle = A * B;
                int Cub = A / C;
                int Cub2 = B / C;
                Answer.Text = $"Ответ: кол-во квадратов в прямоугольнике {Cub*Cub2}. Оставшаяся площадь в прямоугольнике {Triangle-((Cub*Cub2)*Math.Pow(C,2))} ";
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
