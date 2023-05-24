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
    /// Логика взаимодействия для Task9Page.xaml
    /// </summary>
    public partial class Task9Page : Page
    {
        public Task9Page()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            // Дополнительное задание 3

            int A = int.Parse(TbNumberA.Text);
            int B = int.Parse(TbNumberB.Text);




            int remainder = 0;
            while (B != 0)
            {
                remainder = A % B;
                A = B;
                B = remainder;
            }



            TextBlockAnswer.Text = "НОД: " + A;
        }
    }
}
