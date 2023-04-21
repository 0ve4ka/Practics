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
    /// Логика взаимодействия для ExTwoPage.xaml
    /// </summary>
    public partial class ExTwoPage : Page
    {
        public ExTwoPage()
        {
            InitializeComponent();
        }

        private void BtnSub_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int N = int.Parse(TbNumber.Text);
                if (N > 0)
                    Answer.Text = $"Число {N} является положительным {N - 8}";
                else
                    Answer.Text = $"Число {N} не является положительным {N + 6}";
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
