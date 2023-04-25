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
    /// Логика взаимодействия для ExOnePage.xaml
    /// </summary>
    public partial class ExOnePage : Page
    {
        public ExOnePage()
        {
            InitializeComponent();
        }
        public static int Max(int x, int y)
        {
            if (x > y)
                return x;
            else
                return y;
        }
        private void BtnExOne_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int X = int.Parse(TbNbX.Text);
                int Y = int.Parse(TbNbY.Text);

                int z = Max(X, 2 * Y - X) + Max(5 * X + 3 * Y, Y);

                Answer.Text = $"Ответ: {z}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные","Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
