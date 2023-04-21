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
    /// Логика взаимодействия для ExThreePage.xaml
    /// </summary>
    public partial class ExThreePage : Page
    {
        public ExThreePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int F = int.Parse(TbNbFExThree.Text); //значение элеиента
                int N = int.Parse(TbNbNExThree.Text); // номер элемента
                double a, S, h, c;
                switch (N)
                {
                    case 1:
                        a = N;
                        c = a * Math.Sqrt(2);
                        h = c / 2;
                        S = c * h / 2;
                        Answer.Text = $"Ответ: c={c:f2}; h = {h:f2}; S ={S:f2}";
                        break;
                    case 2:
                        c = N;
                        a = c/Math.Sqrt(2);
                        h = c / 2;
                        S = c * h / 2;
                        Answer.Text = $"Ответ: a={a:f2}; h = {h:f2}; S ={S:f2}";
                        break;
                    case 3:
                        h = N;
                        c = h * 2;
                        a = c / Math.Sqrt(2);
                        S = c * h / 2;
                        Answer.Text = $"Ответ: a={a:f2}; c = {c:f2}; S ={S:f2}";
                        break;
                    case 4:
                        S = N;
                        c = 2 * Math.Sqrt(S);
                        h = c / 2;
                        a = c / Math.Sqrt(2);
                        Answer.Text = $"Ответ: a={a:f2}; c = {c:f2}; h ={h:f2}";
                        break;
                }
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
