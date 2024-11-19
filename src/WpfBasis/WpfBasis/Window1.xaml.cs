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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void BackToMainButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow pw = new MainWindow();
            pw.Show();
            this.Close();
        }

        private void TranslateButton_Click(object sender, RoutedEventArgs e)
        {
            List<string> rusWords = new List<string> { "зима", "весна", "лето", "осень", "дождь", "снег", "солнце", "облако", "гроза", "град" };
            List<string> engWords = new List<string> { "winter", "spring", "summer", "autumn", "rain", "snow", "sun", "cloud", "thunderstorm", "hail" };
            string rusText = RussianTextBox.Text.ToLower();
            if (rusWords.Contains(rusText))
                EnglishTextLabel.Content = engWords[rusWords.IndexOf(rusText)];
            else
                MessageBox.Show("Перевод этого слова отсутствует");
        }
    }
}
