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
    /// Логика взаимодействия для ExOnePage.xaml
    /// </summary>
    public partial class ExOnePage : Page
    {
        public ExOnePage()
        {
            InitializeComponent();
        }

        private void BntExOne_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ListBoxExOne.Items.Count <= 1000)
                {
                    int k = 0;
                    for (int i = 0; true; i++)
                    {
                        int Numbers = int.Parse(ListBoxExOne.Items[i].ToString());
                        if (Numbers == 0)
                            break;
                        else if (Numbers % 5 == 0 || Numbers % 9 == 0)
                            k++;
                    }
                    Answer.Text = $"Кол-во чисел кратных 5 или 9: {k}";
                }
               else
                    MessageBox.Show("Вы ввели более 1000 чисел", "Ошибка");
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

        private void BtnAddEXOne_Click(object sender, RoutedEventArgs e)
        {
                int result;
                bool Number = int.TryParse(TbNumbers.Text, out result);
                if (Number)
                    ListBoxExOne.Items.Add(TbNumbers.Text);
                else
                MessageBox.Show("Введены не корректные данные", "Ошибка");
        }
    }
}
