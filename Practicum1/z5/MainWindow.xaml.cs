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
using System.Threading;

namespace z5
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

        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            Thread.Sleep(TimeSpan.FromSeconds(1));
            if(txtQuestion.Text != "" && txtQuestion.Text != "[Введите свой вопрос.]")
            {
                txtAnswer.Text = AnswerGenerator();
                this.Cursor = null;
            }
            else
            {
                MessageBox.Show("Вы не ввели вопрос");
            }
        }

        private string AnswerGenerator()
        {
            string[] answers = new string[] { "Да", "Нет", "Скорее да, чем нет", "Очень сомнительно", "Возможно", "Навряд-ли", "Не знаю" };
            return answers[new Random().Next(0, answers.Length)];
        }

        private void txtQuestion_GotFocus(object sender, RoutedEventArgs e)
        {
            txtQuestion.Text = "";
        }
    }
}
