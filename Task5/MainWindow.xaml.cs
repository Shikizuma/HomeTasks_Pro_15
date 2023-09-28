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

namespace Task5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int number1) && int.TryParse(textBox2.Text, out int number2))
            {
                int result = await Task.Run(() => Addition(number1, number2)).ConfigureAwait(false);

                Application.Current.Dispatcher.Invoke(() =>
                {
                    textBoxResult.Text = result.ToString();
                });
            }
            else
            {
                MessageBox.Show("Введіть коректні числа.");
            }
        }

        private int Addition(int a, int b)
        {
            return a + b;
        }
    }
}
