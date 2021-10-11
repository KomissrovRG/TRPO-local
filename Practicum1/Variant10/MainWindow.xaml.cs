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

namespace Variant10
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

        private void average1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void average2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void average3_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void speed1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void speed2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void speed3_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (average1.Text != "0" && average1.Text != "" && average2.Text != "0" && average2.Text != "" && average3.Text != "0" && average3.Text != "" && speed1.Text != "0" && speed1.Text != "" && speed2.Text != "0" && speed2.Text != "" && speed3.Text != "0" && speed3.Text != "")
            {
                double s1 = Convert.ToDouble(average1.Text), s2 = Convert.ToDouble(average2.Text), s3 = Convert.ToDouble(average3.Text);
                double v1 = Convert.ToDouble(speed1.Text), v2 = Convert.ToDouble(speed2.Text), v3 = Convert.ToDouble(speed3.Text);
                try
                {
                    res.Content = "Средняя скорость = " + Math.Round((s1 + s2 + s3) / (s1 / v1 + s2 / v2 + s3 / v3),2);
                }
                catch
                {
                    res.Content = "Такого не может быть";
                }
            }
            else
            {
                MessageBox.Show("Вы что-то не ввели");
            }
        }
    }
}
