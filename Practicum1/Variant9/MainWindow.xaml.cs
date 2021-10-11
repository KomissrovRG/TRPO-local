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

namespace Variant9
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
            if (first.Text != "" && first.Text != "0" && second.Text != "" && second.Text != "0")
            {
                Random rand = new Random();
                double a = rand.Next(Convert.ToInt32(first.Text), Convert.ToInt32(second.Text));
                double b = rand.Next(Convert.ToInt32(first.Text), Convert.ToInt32(second.Text));
                g.Content = "Гипотенуза = " + Math.Round(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)), 2);
                s.Content = "Площадь = " + Math.Round(a * b / 2, 2);
                catet1.Content = "Первый катет = " + a.ToString();
                catet2.Content = "Второй катет = " + b.ToString();
            }
            else
            {
                MessageBox.Show("Введите границы рандома (катет не должен ровняться 0)");
            }
        }

        private void first_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void second_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }
    }
}
