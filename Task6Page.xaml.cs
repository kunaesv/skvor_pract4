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
    /// Логика взаимодействия для Task6Page.xaml
    /// </summary>
    public partial class Task6Page : Page
    {
        public Task6Page()
        {
            InitializeComponent();
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            // Задание 6 

            int n;
            if (!int.TryParse(TbNumberA.Text, out n))
            {
                TextBlockAnswer.Text = "Введите целочисленное значение!";
                return;
            }

            bool hasOne = false;
            while (n > 0)
            {
                int digit = n % 10;
                if (digit == 1)
                {
                    hasOne = true;
                    break;
                }
                n = n / 10;
            }

            TextBlockAnswer.Text = hasOne ? "true" : "false";
        }
    }
}
