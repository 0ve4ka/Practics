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
    /// Логика взаимодействия для ExFivePage.xaml
    /// </summary>
    public partial class ExFivePage : Page
    {
        public ExFivePage()
        {
            InitializeComponent();
        }

       public static float Triangle(float x, float y, float z)
        {
            float p = (x + y + z) / 2;

            float S = (float)Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return S;
        }
        private void BtnExFive_Click(object sender, RoutedEventArgs e)//Кнопка "Вычеслить"
        {
            try
            {
                float a = Single.Parse(ListBoxExFive.Items[0].ToString());
                float b = Single.Parse(ListBoxExFive.Items[1].ToString());
                float c = Single.Parse(ListBoxExFive.Items[2].ToString());
                float d = Single.Parse(ListBoxExFive.Items[3].ToString());
                float E = Single.Parse(ListBoxExFive.Items[4].ToString());
                float f = Single.Parse(ListBoxExFive.Items[5].ToString());
                float g = Single.Parse(ListBoxExFive.Items[6].ToString());

                float answer = Triangle(a,b,f) + Triangle(E,g,d) + Triangle(f,c,g);

                Answer.Text = $"Площадь фигуры равна: {answer:f2}";
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

        private void BtnAdd_Click(object sender, RoutedEventArgs e) //Кнопка "Добавить"
        {
            float resulte;
            bool answer = Single.TryParse(TbAdd.Text, out resulte);
            if (answer)
                ListBoxExFive.Items.Add(TbAdd.Text);
            else
                MessageBox.Show("Введены не корректные данные", "Ошибка");
        }
    }
}
