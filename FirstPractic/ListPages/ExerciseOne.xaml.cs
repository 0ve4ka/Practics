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
using static System.Math;

namespace FirstPractic.ListPages
{
    /// <summary>
    /// Логика взаимодействия для ExerciseOne.xaml
    /// </summary>
    public partial class ExerciseOne : Page
    {
        public ExerciseOne()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float NumberA = Single.Parse(TbNbA.Text);
                Answer.Text = $"Ответ: площадь квадрата S равна {Pow(NumberA, 2)}";
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
