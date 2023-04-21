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
    /// Логика взаимодействия для ExFourPage.xaml
    /// </summary>
    public partial class ExFourPage : Page
    {
        public ExFourPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = int.Parse(TbNbAExFour.Text);
                int B = int.Parse(TbNbBExFour.Text);
                int k =0;
                if (A > B)
                {
                    while (true)
                    {
                        A -= B;
                        k++;
                        if (A < B)
                        {
                            Answer.Text = $"Кол-во отрезков В на отрезке А: {k}";
                            break;
                        }
                            
                    }
                }
                else
                    Answer.Text = $"Кол-во отрезков В на отрезке А: 0";
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
