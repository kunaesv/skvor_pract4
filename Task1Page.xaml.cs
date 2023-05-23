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
    /// Логика взаимодействия для Task1Page.xaml
    /// </summary>
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            // Задание 1

            int day, month;
            if (!int.TryParse(TbNumberA.Text, out day) || !int.TryParse(TbNumberB.Text, out month))
            {
                TextBlockAnswer.Text = "Введите целочисленные значения!";
                return;
            }

            if (day < 1 || day > 31 || month < 1 || month > 12)
            {
                TextBlockAnswer.Text = "Некорректная дата!";
                return;
            }

            switch (day)
            {
                case 31:
                    switch (month)
                    {
                        case 12:
                            day = 1;
                            month = 1;
                            break;
                        default:
                            day = 1;
                            month++;
                            break;
                    }
                    break;
                case 30:
                    switch (month)
                    {
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            day = 1;
                            month++;
                            break;
                        default:
                            day++;
                            break;
                    }
                    break;
                case 28:
                    switch (month)
                    {
                        case 2:
                            day = 1;
                            month++;
                            break;
                        default:
                            day++;
                            break;
                    }
                    break;
                default:
                    day++;
                    break;
            }

            TextBlockAnswer.Text = $"Следующая дата: {day}.{month:D2}";
        }

    }
}