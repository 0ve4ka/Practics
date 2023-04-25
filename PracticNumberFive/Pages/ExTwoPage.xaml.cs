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
    /// Логика взаимодействия для ExTwoPage.xaml
    /// </summary>
    public partial class ExTwoPage : Page
    {
        public ExTwoPage()
        {
            InitializeComponent();
        }

        private void BtnAddExTwo_Click(object sender, RoutedEventArgs e)
        {
            int result;
            bool Number = int.TryParse(TbNumbersExTwo.Text, out result);
            if (Number)
                ListBoxExTwo.Items.Add(TbNumbersExTwo.Text);
            else
                MessageBox.Show("Введены не корректные данные", "Ошибка");
        }

        private void BntExTwo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ListBoxExTwo.Items.Count <= 1000)
                {
                    int k = 0;
                    int Count = int.Parse(ListBoxExTwo.Items[0].ToString());
                    for (int i = 1; i <= Count; i++)
                    {
                        int Number = int.Parse(ListBoxExTwo.Items[i].ToString());
                        if (Number % 3 == 0 && Number % 10 == 2)
                            k++;
                    }
                    Answer.Text = $"Кол-во чисел кратных трёх и оканчивающихся 2: {k}";
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
    }
}
