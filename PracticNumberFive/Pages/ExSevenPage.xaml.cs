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
    /// Логика взаимодействия для ExSevenPage.xaml
    /// </summary>
    public partial class ExSevenPage : Page
    {
        public ExSevenPage()
        {
            InitializeComponent();
        }

        private void BtnExSeven_Click(object sender, RoutedEventArgs e)
        {


            int Fact(int n)
            {
                int x = 1;
                for (int i = 1; i <= n; i++)
                {
                    x *= i;
                }
                return x;
            }
            try
            {
                float E = Single.Parse(TBoxNbE.Text);

                float ResultA = 0; 
                // A)
                for (int i = 1; true; i++)
                {
                   float Number = 1 / (float)Math.Pow(i, 2);
                    if (Math.Abs((float)Number) > E)
                        ResultA += Number;
                    else
                        break;
                }

                float ResultB = 0; 
                // Б) 
                for (int i = 1; true; i++)
                {
                    float Number = 1 / (i * (i + 1));
                    if (Math.Abs((float)Number) > E)
                        ResultB += Number;
                    else
                        break;
                }

                float ResultC = 0;
                // В)
                for (int i = 1; true; i++)
                {
                    float Number = (float)Math.Pow(-1, i) / Fact(i);
                    if (Math.Abs((float)Number) > E)
                        ResultC += Number;
                    else
                        break;
                }

                float ResultD = 0;
                // Г)
                for (int i = 0; true; i++)
                {
                    float Number = (float)Math.Pow(-2, i) / Fact(i);
                    if (Math.Abs((float)Number) > E)
                        ResultD+= Number;
                    else
                        break;
                }

                float ResultE = 0;
                // Д)
                for (int i = 1; true; i++)
                {
                    float Number = (float)Math.Pow(-1, i + 1) / (i * (i + 1) * (i + 2));
                    if (Math.Abs((float)Number) > E)
                        ResultE += Number;
                    else
                        break;
                }

                float ResultF = 0;
                // Е)
                for (int i = 0; true; i++)
                {
                    float Number = 1 / (float)(Math.Pow(4, i) + Math.Pow(5, i + 2));
                    if (Math.Abs((float)Number) > E)
                        ResultF += Number;
                    else
                        break;
                }

                Answer.Text = $"Ответ: а) {ResultA:F2}; б) {ResultB:F2}; в) {ResultC:f2}; г) {ResultD:F2}; д) {ResultE:f2}; е) {ResultF:f2}";
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
