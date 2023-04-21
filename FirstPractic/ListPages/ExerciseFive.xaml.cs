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
    /// Логика взаимодействия для ExerciseFive.xaml
    /// </summary>
    public partial class ExerciseFive : Page
    {
        public ExerciseFive()
        {
            InitializeComponent();
        }

      

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            try
            {
                float A1 = Single.Parse(TbNbA1.Text);
                float B1 = Single.Parse(TbNbB1.Text);
                float C1 = Single.Parse(TbNbC1.Text);
                float A2 = Single.Parse(TbNbA2.Text);
                float B2 = Single.Parse(TbNbB2.Text);
                float C2 = Single.Parse(TbNbC2.Text);
                float D = A1 * B2 - A2 * B1;
                float x = (C1 * B2 - C2 * B1) / D;
                float y = (A1 * C2 - A2 * C1) / D;
                Answer.Text = $"Ответ: Значение x = {x:f2}; значение y = {y:f2} ";


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
