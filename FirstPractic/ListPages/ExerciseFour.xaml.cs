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
    /// Логика взаимодействия для ExerciseFour.xaml
    /// </summary>
    public partial class ExerciseFour : Page
    {
        public ExerciseFour()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double NbB = double.Parse(TbNbB.Text);
                double NbP = double.Parse(TbNbP.Text);

                double A = Math.Cos(NbB) + 5.1 * Math.Pow(10, -3);
                double W = (Math.Pow(A, 5) + Math.Sin((A * NbB))) / (Math.Sqrt((A * NbB)) + Math.Tan(NbB));
                double v = Math.Exp(A * W) + NbP;

                Answer.Text = $"Ответ: Значение выражения (числа V) равно {v:f2}";
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
