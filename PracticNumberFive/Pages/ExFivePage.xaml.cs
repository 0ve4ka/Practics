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

namespace PracticNumberFive.Pages
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

        private void BtnExFive_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float b = 1, a = 1, f;
                int N = int.Parse(TBoxNbN.Text);

                float Result = 1;

                for (int k = 1; k <= N; k++)
                {
                    Result *= a * b;
                    f = a;
                    a = 1/2f *(float)(Math.Sqrt(b) + 1/2f * Math.Sqrt(a));
                    b = 2 * (float)Math.Pow(f, 2) + b;
                }
                Answer.Text=$"Ответ: {Result}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
