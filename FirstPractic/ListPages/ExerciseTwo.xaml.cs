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

namespace FirstPractic.ListPages
{
    /// <summary>
    /// Логика взаимодействия для ExerciseTwo.xaml
    /// </summary>
    public partial class ExerciseTwo : Page
    {
        public ExerciseTwo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float S = Single.Parse(TbNbS.Text);
                const double PI = 3.14;

                float D = (float)Math.Sqrt(S * 4 / PI);
                float L = (float)PI * D;

                Answer.Text = $"Ответ: Диаметр круга D равен {D:f2}; Длина круга L равна {L:f2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введена строка", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
