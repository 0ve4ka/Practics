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
    /// Логика взаимодействия для ExNinePage.xaml
    /// </summary>
    public partial class ExNinePage : Page
    {
        public ExNinePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = int.Parse(TbNbAExNine.Text);
                int B = int.Parse(TbNbBExNine.Text);
                int s= 1;

                //Ниже пробный вариант (кастыльный)

                if (A > B)
                {
                    if (B != 0)
                    {
                        s = A % B;//Первый остаток
                        while (true)
                        {
                            B %= s;//Второй остаток
                            if (B == 0)
                            {
                                Answer.Text = $"НОД = {s}";
                                break;
                            }
                            else
                                s %= B;
                        }
                    }
                   else
                        Answer.Text = $"НОД = {A}";
                }
                else if (A != 0)
                    {
                        s = B % A; //Первый остаток
                        while (true)
                        {
                            A %= s;//Второй остаток
                            if (A == 0)
                            {
                                Answer.Text = $"НОД = {s}";
                                break;
                            }
                            else
                                s %= A;
                        }
                    }
                   else
                        Answer.Text = $"НОД = {B}";
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
