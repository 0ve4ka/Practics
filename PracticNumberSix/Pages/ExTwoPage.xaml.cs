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
    /// Логика взаимодействия для ExTwoPage.xaml
    /// </summary>
    public partial class ExTwoPage : Page
    {
        public ExTwoPage()
        {
            InitializeComponent();
        }
        public static int F(int X)
        {
            int num = X % 100;//нашел двухзначное число
            X -= num;//Избавился от неего
            int f = num % 10;//Сохранил единицы
            num /= 10; // Сохранил десятые
            f *= 10; //Сделал единицы десятыми
            f += num;//Сделал десятые единицами
            X += f;//Вернул на место
            return X;
        }
        private void BtnExTwo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = int.Parse(TbNbX.Text);

                Answer.Text = $"Ответ: {F(x)}";
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
