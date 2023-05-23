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

namespace skvor_pract4
{
    /// <summary>
    /// Логика взаимодействия для Task2Page.xaml
    /// </summary>
    public partial class Task2Page : Page
    {
        public Task2Page()
        {
            InitializeComponent();
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            // Задание 2

            int value, suit;
            if (!int.TryParse(TbNumberN.Text, out value) || !int.TryParse(TbNumberM.Text, out suit))
            {
                TextBlockAnswer.Text = "Введите целочисленные значения!";
                return;
            }

            if (value < 6 || value > 14 || suit < 1 || suit > 4)
            {
                TextBlockAnswer.Text = "Некорректное значение достоинства или масти!";
                return;
            }

            string valueName;
            switch (value)
            {
                case 6:
                    valueName = "шестерка";
                    break;
                case 7:
                    valueName = "семерка";
                    break;
                case 8:
                    valueName = "восьмерка";
                    break;
                case 9:
                    valueName = "девятка";
                    break;
                case 10:
                    valueName = "десятка";
                    break;
                case 11:
                    valueName = "валет";
                    break;
                case 12:
                    valueName = "дама";
                    break;
                case 13:
                    valueName = "король";
                    break;
                default:
                    valueName = "туз";
                    break;
            }

            string suitName;
            switch (suit)
            {
                case 1:
                    suitName = "пик";
                    break;
                case 2:
                    suitName = "треф";
                    break;
                case 3:
                    suitName = "бубен";
                    break;
                default:
                    suitName = "червей";
                    break;
            }

            TextBlockAnswer.Text = $"{valueName} {suitName}";

        }
    }
}
