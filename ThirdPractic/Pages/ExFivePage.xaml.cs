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
    /// Логика взаимодействия для ExFivePage.xaml
    /// </summary>
    public partial class ExFivePage : Page
    {
        public ExFivePage()
        {
            InitializeComponent();
        }

        private void BtnSubEx5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int X = int.Parse(TbNumberX.Text);
                int Y = int.Parse(TbNumberY.Text);

                if (Math.Pow(X, 2) + Math.Pow(X, 2) < 100  && Y < X && X > 0 || Math.Pow(X, 2) + Math.Pow(X, 2) < 100  && Y < -X && X < 0 )
                    Answer.Text = "Да";
                else if (X > 0 && Y > X && Math.Pow(X, 2) + Math.Pow(X, 2) > 100 || X < 0 && Y > -X && Math.Pow(X, 2) + Math.Pow(X, 2) > 100)
                    Answer.Text = "Нет";
                else
                    Answer.Text = "На границе";
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
