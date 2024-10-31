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

namespace Variant3
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public static double one;
        public static double two;
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
            if(Volume.IsChecked == true && Mass.IsChecked == true)
            {
                one = (3.14 * Math.Pow(Convert.ToDouble(Radius.Text), 2) * Convert.ToDouble(Height.Text) / 3);
                two = (Convert.ToDouble(Radius.Text) * Convert.ToDouble(Height.Text) * Convert.ToDouble(Density.Text) / 3);
            }
            else if(Volume.IsChecked == true)
            {
                if(Radius.Text != null && Height.Text != null)
                {
                    one = (3.14 * Math.Pow(Convert.ToDouble(Radius.Text), 2) * Convert.ToDouble(Height.Text) / 3);
                }
                else
                {
                    MessageBox.Show("Какая-то переменая не указана", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if(Mass.IsChecked == true)
            {
                if (Radius.Text != null && Height.Text != null && Density.Text != null)
                {
                    two = (Convert.ToDouble(Radius.Text) * Convert.ToDouble(Height.Text) * Convert.ToDouble(Density.Text) / 3);
                }
                else
                {
                    MessageBox.Show("Какая-то переменая не указана", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Вы не указали действие", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
