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
    /// Логика взаимодействия для ExSixPage.xaml
    /// </summary>
    public partial class ExSixPage : Page
    {
        public ExSixPage()
        {
            InitializeComponent();
        }

        private void BtnSubExSix_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int N = int.Parse(TbNumberN.Text);

                if (N != 0)
                    if (N > 0)
                        if (N % 2 == 0)
                            Answer.Text = "Число положительное и чётное";
                         else
                            Answer.Text = "Число положительное и нечётное";
                    else if(N % 2 == 0)
                        Answer.Text = "Число отрицательное и чётное";
                        else
                            Answer.Text = "Число отрицательное и нечётное";
              else
                    Answer.Text = "Число нулевое";
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
