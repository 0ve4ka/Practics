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
    /// Логика взаимодействия для ExThreePage.xaml
    /// </summary>
    public partial class ExThreePage : Page
    {
        public ExThreePage()
        {
            InitializeComponent();
        }

        private void TbSub_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = int.Parse(TbNumberA.Text);
                int B = int.Parse(TbNumberB.Text);
                int C = int.Parse(TbNumberC.Text);

                if (A == C)
                    Answer.Text = "Число, отличное от двух других имеет порядковый номер 2";
                else if (A == B)
                    Answer.Text = "Число, отличное от двух других имеет порядковый номер 3";
                else 
                    Answer.Text = "Число, отличное от двух других имеет порядковый номер 1";
                
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
