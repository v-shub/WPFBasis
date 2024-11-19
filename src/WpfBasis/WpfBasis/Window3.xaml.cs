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

namespace WpfBasis
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void BackToMainButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow pw = new MainWindow();
            pw.Show();
            this.Close();
        }

        private void FindInterval_Click(object sender, RoutedEventArgs e)
        {
            string intervalString = "Промежуток: ";
            if (!Int32.TryParse(NumBox.Text, out int interval))
                MessageBox.Show("Введено не целое число");
            else
            {
                if (interval < 0 | interval > 100)
                    IntervalLabel.Content = "Число не попадает ни в один из промежутков";
                else if (interval < 15)
                    IntervalLabel.Content = intervalString + "0 - 14";
                else if (interval < 36)
                    IntervalLabel.Content = intervalString + "15 - 35";
                else if (interval < 50)
                    IntervalLabel.Content = intervalString + "36 - 50";
                else if (interval == 50)
                    IntervalLabel.Content = "Промежутки: 36 - 50 и 50 - 100";
                else
                    IntervalLabel.Content = intervalString + "50 - 100";
            }
        }
    }
}
