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

namespace Variant7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int n = rand.Next(10, 99);
            number.Content = "Число = " + n;
            int ressum = 0, resmulti = 1;
            while (n != 0)
            {
                ressum += n % 10;
                resmulti *= n % 10;
                n /= 10;
            }
            sum.Content = "Сумма цифр  = " + ressum;
            multi.Content = "Произведение цифр  = " + resmulti;
        }
    }
}
