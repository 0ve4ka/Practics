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
    /// Логика взаимодействия для ExEightPage.xaml
    /// </summary>
    public partial class ExEightPage : Page
    {
        public ExEightPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int D = int.Parse(TbNbDExEight.Text);

                string[] NumS = { " ", "Сто", "Двести", "Триста", "Четыреста", "Пятьсот", "Шестьсот", "Семьсот", "Восемьсот", "Девятьсот" }; //Сотни
                string[] NumD = { " ", "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };//Десятки
                string[] NumE = { " ", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" }; //Единицы
                if (D >= 100 && D <= 999)
                {
                    int f = D % 10; //Единицы
                    D /= 10;
                    int g = D % 10; //Десятки
                    D /= 10; //Сотни

                    if (g == 1)
                        switch (f)
                        {
                            case 1:
                                Answer.Text = $"{NumS[D]} одиннацать";
                                break;
                            case 2:
                                Answer.Text = $"{NumS[D]} двенадцать";
                                break;
                            case 3:
                                Answer.Text = $"{NumS[D]} тринадцать";
                                break;
                            case 4:
                                Answer.Text = $"{NumS[D]} четырнадцать";
                                break;
                            case 5:
                                Answer.Text = $"{NumS[D]} пятнадцать";
                                break;
                            case 6:
                                Answer.Text = $"{NumS[D]} шестнадцать";
                                break;
                            case 7:
                                Answer.Text = $"{NumS[D]} семнадцать";
                                break;
                            case 8:
                                Answer.Text = $"{NumS[D]} восемнацать";
                                break;
                            case 9:
                                Answer.Text = $"{NumS[D]} девятнадцать";
                                break;
                            default:
                                Answer.Text = $"{NumS[D]} {NumD[g]}";
                                break;
                        }
                    else
                        Answer.Text = $"{NumS[D]} {NumD[g]} {NumE[f]}";
                }
                else
                    Answer.Text = "Нужно число в диапазоне [100-999]";
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
