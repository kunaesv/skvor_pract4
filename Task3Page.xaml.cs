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
    /// Логика взаимодействия для Task3Page.xaml
    /// </summary>
    public partial class Task3Page : Page
    {
        public Task3Page()
        {
            InitializeComponent();
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            // Задание 3

            int number, value;
            if (!int.TryParse(TbNumberA.Text, out number) || !int.TryParse(TbNumberB.Text, out value))
            {
                TextBlockAnswer.Text = "Введите целочисленные значения!";
                return;
            }

            double a, R1, R2, S;
            switch (number)
            {
                case 1:
                    a = value;
                    R1 = a * Math.Sqrt(3) / 4;
                    R2 = 2 * R1;
                    S = a * a * Math.Sqrt(3) / 4;
                    break;
                case 2:
                    R1 = value;
                    a = R1 * 4 / Math.Sqrt(3);
                    R2 = 2 * R1;
                    S = a * a * Math.Sqrt(3) / 4;
                    break;
                case 3:
                    R2 = value;
                    R1 = R2 / 2;
                    a = R1 * 4 / Math.Sqrt(3);
                    S = a * a * Math.Sqrt(3) / 4;
                    break;
                default:
                    S = value;
                    a = Math.Sqrt(S * 4 / Math.Sqrt(3));
                    R1 = a * Math.Sqrt(3) / 4;
                    R2 = 2 * R1;
                    break;
            }

            TextBlockAnswer.Text = $"a = {a:F2}, R1 = {R1:F2}, R2 = {R2:F2}, S = {S:F2}";

        }
    }
}
