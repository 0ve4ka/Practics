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
    /// Логика взаимодействия для ExSevenPage.xaml
    /// </summary>
    public partial class ExSevenPage : Page
    {
        public ExSevenPage()
        {
            InitializeComponent();
        }

        private void BtnSubExSeven_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int F = int.Parse(TbNumberF.Text);

                if (F >= 1 && F <= 999)
                {
                    if (F / 100 != 0)
                        if (F % 2 == 0)
                            Answer.Text = "Трёхзначное чётное число";
                        else
                            Answer.Text = "Трёхзначное нечётное число";
                    else if (F / 10 != 0)
                        if (F % 2 == 0)
                            Answer.Text = "Двухзначное чётное число";
                        else
                            Answer.Text = "Двухзначное нечётное число";
                    else if(F%2==0)
                        Answer.Text = "Однозначное чётное число";
                    else
                        Answer.Text = "Однозначное нечётное число";

                }
                else
                    Answer.Text = "Число не лежит в заданном диапазоне";
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
