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
    /// Логика взаимодействия для ExSixPage.xaml
    /// </summary>
    public partial class ExSixPage : Page
    {
        public ExSixPage()
        {
            InitializeComponent();
        }

        private void BtnExSix_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int N = int.Parse(TBoxNbN.Text);
                int K = int.Parse(TBoxNbK.Text);

                double Result = 0;

                for (int i = 1; i <= N; i++)
                    Result += Math.Pow(i, K);
                Answer.Text = $"Ответ: {Result}";
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
