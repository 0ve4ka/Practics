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
    /// Логика взаимодействия для ExThreePage.xaml
    /// </summary>
    public partial class ExThreePage : Page
    {
        public ExThreePage()
        {
            InitializeComponent();
        }

       public static int RootCount(float a, float b, float c)
        {
            float D = (float)Math.Pow(b, 2) - 4 * a * c;

            if (D > 0)
                return 2;
            else if (D == 0)
                return 1;
            else
                return 0;
        }
        private void BtnExThree_Click(object sender, RoutedEventArgs e)
        {
           
            try
            {
                float A = Single.Parse(TbNbA.Text);
                float B = Single.Parse(TbNbB.Text);
                float C = Single.Parse(TbNbC.Text);

                Answer.Text = $"Ответ: кол-во корней в уравнении {RootCount(A,B,C)}";

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
