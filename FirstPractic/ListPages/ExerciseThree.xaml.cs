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
    /// Логика взаимодействия для ExerciseThree.xaml
    /// </summary>
    public partial class ExerciseThree : Page
    {
        public ExerciseThree()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float NbA = Single.Parse(TbNbA.Text);
                float NbB = Single.Parse(TbNbB.Text);

                if (NbA == 0)
                    MessageBox.Show(" Вы ввели ноль в число A", "Ошибка");
                else
                {
                    float X = -NbB / NbA;
                    Answer.Text = $"Ответ: X = {X}";
                }
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
