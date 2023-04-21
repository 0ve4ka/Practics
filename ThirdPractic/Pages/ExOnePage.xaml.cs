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
    /// Логика взаимодействия для ExOnePage.xaml
    /// </summary>
    public partial class ExOnePage : Page
    {
        public ExOnePage()
        {
            InitializeComponent();
        }

        private void BtnSub_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                int Number = int.Parse(TbNumber.Text);
                if (Number % 10 == 7)
                    Answer.Text = $"Данное число {Number} оканчивается семёркой";
                else
                    Answer.Text = $"Данное число {Number}  не оканчивается семёркой";
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
