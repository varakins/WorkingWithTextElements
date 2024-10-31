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
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private string sdf;
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow secondWindow = new MainWindow();
            secondWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(sdf != "")
            {
                MessageBox.Show($"Переведено:\n {sdf}", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Вы ещё не перевели число", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string input = TextNumber.Text;
            if (Option1.IsChecked == true)
            {
                if (int.TryParse(input, out int decimalNumber) && decimalNumber >= 0)
                {
                    sdf = Convert.ToString(decimalNumber, 2);
                }
            }
            else if(Option2.IsChecked == true)
            {
                if (int.TryParse(input, out int decimalNumber) && decimalNumber >= 0)
                {
                    sdf = Convert.ToString(decimalNumber, 8);
                }
            }
            else if (Option3.IsChecked == true)
            {
                if (int.TryParse(input, out int decimalNumber) && decimalNumber >= 0)
                {
                    sdf = Convert.ToString(decimalNumber, 16);
                }
            }
            else
            {
                MessageBox.Show("Не указано во что переводим", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
