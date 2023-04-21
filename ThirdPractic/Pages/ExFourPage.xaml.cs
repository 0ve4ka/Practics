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

namespace ThirdPractic.Pages
{
    /// <summary>
    /// Логика взаимодействия для ExFourPage.xaml
    /// </summary>
    public partial class ExFourPage : Page
    {
        public ExFourPage()
        {
            InitializeComponent();
        }

        private void TbSub_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int K = int.Parse(TbNumK.Text);
                int X = int.Parse(TbNumX.Text);
                switch (K)
                {
                    case 3:
                        Answer.Text = $"Значение Y = {Math.Sin(X) + 2:f2}";
                        break;
                    case 20:
                        Answer.Text = $"Значение Y = {Math.Cos(Math.Pow(X, 2)) + 2:f2}";
                        break;
                    case 10:
                        Answer.Text = $"Значение Y = {Math.Tan(X) + Math.Sin(X):f2}";
                        break;
                    case 15:
                        Answer.Text = $"Значение Y = {Math.Tan(X) + Math.Sin(X):f2}";
                        break;
                    default:
                        Answer.Text = $"Значение Y не определено";
                        break;
                }
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
