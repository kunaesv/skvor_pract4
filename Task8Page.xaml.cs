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
    /// Логика взаимодействия для Task8Page.xaml
    /// </summary>
    public partial class Task8Page : Page
    {
        public Task8Page()
        {
            InitializeComponent();
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            // Дополнительное задание 2 

            int n = int.Parse(TbNumberA.Text);
            int fn = n / 100, sn = n / 10 % 10, tn = n % 10;
            string str = "";

            switch (fn)
            {
                case 1:
                    str += "cто ";
                    break;
                case 2:
                    str += "двести ";
                    break;
                case 3:
                    str += "триста ";
                    break;
                case 4:
                    str += "четыреста ";
                    break;
                case 5:
                    str += "пятьсот ";
                    break;
                case 6:
                    str += "шестьсот ";
                    break;
                case 7:
                    str += "семьсот ";
                    break;
                case 8:
                    str += "восемьсот ";
                    break;
                case 9:
                    str += "девятьсот ";
                    break;
            }

            switch (sn)
            {
                case 1:
                    switch (tn)
                    {
                        case 0:
                            str += "десять";
                            break;
                        case 1:
                            str += "одиннадцать";
                            break;
                        case 2:
                            str += "двеннадцать";
                            break;
                        case 3:
                            str += "тринадцать";
                            break;
                        case 4:
                            str += "четырнадцать";
                            break;
                        case 5:
                            str += "пятнадцать";
                            break;
                        case 6:
                            str += "шеснадцать";
                            break;
                        case 7:
                            str += "семнадцать";
                            break;
                        case 8:
                            str += "восемнадцать";
                            break;
                        case 9:
                            str += "девятнадцать";
                            break;
                    };
                    break;
                case 2:
                    str += "двадцать ";
                    break;
                case 3:
                    str += "тридцать ";
                    break;
                case 4:
                    str += "сорок ";
                    break;
                case 5:
                    str += "пятьдесят ";
                    break;
                case 6:
                    str += "шестьдесят ";
                    break;
                case 7:
                    str += "семьдесят ";
                    break;
                case 8:
                    str += "восемдесят ";
                    break;
                case 9:
                    str += "девяносто ";
                    break;
            }
            if (sn != 1)
            {
                switch (tn)
                {
                    case 1:
                        str += "один";
                        break;
                    case 2:
                        str += "два";
                        break;
                    case 3:
                        str += "три";
                        break;
                    case 4:
                        str += "четыре";
                        break;
                    case 5:
                        str += "пять";
                        break;
                    case 6:
                        str += "шесть";
                        break;
                    case 7:
                        str += "семь";
                        break;
                    case 8:
                        str += "восемь";
                        break;
                    case 9:
                        str += "девять";
                        break;
                }
            }

            TextBlockAnswer.Text = str;
        }
    }
}
