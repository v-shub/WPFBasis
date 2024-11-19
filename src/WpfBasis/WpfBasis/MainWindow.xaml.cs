using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBasis
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

        private void Task1Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 pw = new Window1();
            pw.Show();
            this.Close();
        }

        private void Task2Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 pw = new Window2();
            pw.Show();
            this.Close();
        }

        private void Task3Button_Click(object sender, RoutedEventArgs e)
        {
            Window3 pw = new Window3();
            pw.Show();
            this.Close();
        }

        private void Task4Button_Click(object sender, RoutedEventArgs e)
        {
            Window4 pw = new Window4();
            pw.Show();
            this.Close();
        }
    }
}