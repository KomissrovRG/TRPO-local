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

namespace Variant4
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
            if(first.Text != "" && second.Text != "")
            {
                int a = rand.Next(Convert.ToInt32(first.Text), Convert.ToInt32(second.Text));
                int b = rand.Next(Convert.ToInt32(first.Text), Convert.ToInt32(second.Text));
                int c = rand.Next(Convert.ToInt32(first.Text), Convert.ToInt32(second.Text));
                sr.Content = "Среднее арифметическое = " + Math.Round(Convert.ToDouble((a + b + c)/3.0),2).ToString();
                atext.Content = "a = " + a.ToString();
                btext.Content = "b = " + b.ToString();
                ctext.Content = "c = " + c.ToString();
            }
            else
            {
                MessageBox.Show("Вы не ввели границы рандома");
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
