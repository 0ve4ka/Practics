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

namespace FourthPractic.Pages
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int K = int.Parse(TbNbNExOne.Text);

                switch (K)
                {
                    case 1:
                        Answer.Text = "Плохо";
                        break;
                    case 2:
                        Answer.Text = "Неудовлетворительно";
                        break;
                    case 3:
                        Answer.Text = "Удовлетворительно";
                        break;
                    case 4:
                        Answer.Text = "Хорошо";
                        break;
                    case 5:
                        Answer.Text = "Отлично";
                        break;
                    default:
                        Answer.Text = "Ошибка";
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы ввели не корректные данные","Ошибка");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
