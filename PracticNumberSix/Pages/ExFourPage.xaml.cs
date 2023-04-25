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


namespace PracticNumberSix.Pages
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

      public static float Function(float x, float a)
        {
            float y;
                if (x < a)
                {
                    y = 0;
                    return y;
                }
                else if (x > a)
                {
                    y = (x - a) / (x + a);
                    return y;
                }
                else
                {
                    y = 1;
                    return y;
                }
        }
        private void BtnExFour_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float X = Single.Parse(TbNbX.Text);
                float A = Single.Parse(TbNbA.Text);
                float B = Single.Parse(TbNbB.Text);
                float H = Single.Parse(TbNbH.Text);

                for (; A <= B; A += H)
                {
                    float Y = Function(X, A);
                    ListBoxExFour.Items.Add($"y= {Y}, при x({X}),a({A}) c шагом h {H} ");
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
