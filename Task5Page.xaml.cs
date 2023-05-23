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
    /// Логика взаимодействия для Task5Page.xaml
    /// </summary>
    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            // Задание 5

            int n;
            if (!int.TryParse(TbNumberA.Text, out n))
            {
                TextBlockAnswer.Text = "Введите целочисленное значение!";
                return;
            }

            int k = 1;
            int sum = 0;
            while (sum + k <= n)
            {
                sum += k;
                k++;
            }

            TextBlockAnswer.Text = $"Наибольшее целое число K: {k - 1}, сумма: {sum}";


        }
    }
}
