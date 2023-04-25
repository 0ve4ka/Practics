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

namespace PracticNumberFive.Pages
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

        private void BtnExThree_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = int.Parse(TBoxNbA.Text);
                int B = int.Parse(TBoxNbB.Text);

                if (A < B)
                {
                    int i = 0;
                    string answer = ": ";
                    for (;B>=A;i++)
                    {
                        answer += B+", ";
                        B--;
                    }
                    Answer.Text = $"Ответ{answer}; Кол-во чисел {i}";
                }
                else
                    MessageBox.Show("Нужно, чтобы число А было меньше числа В","Ошибка");
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
