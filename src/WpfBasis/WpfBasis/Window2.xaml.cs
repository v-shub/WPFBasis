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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void BackToMainButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow pw = new MainWindow();
            pw.Show();
            this.Close();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            string wrongInputMessage = "Вы ввели что-то не то";
            bool isOperand1 = Int32.TryParse(Operand1Box.Text, out int operand1);
            bool isOperand2 = Int32.TryParse(Operand2Box.Text, out int operand2);
            if (!isOperand1 || !isOperand2)
                MessageBox.Show(wrongInputMessage);
            else
            {
                switch (SignBox.Text)
                {
                    case "+":
                        ResultLabel.Content = operand1 + operand2;
                        break;
                    case "-":
                        ResultLabel.Content = operand1 - operand2;
                        break;
                    case "*":
                        ResultLabel.Content = operand1 * operand2;
                        break;
                    case "/":
                        if(operand2==0)
                            MessageBox.Show("Делить на ноль нельзя!");
                        else
                            ResultLabel.Content = operand1 / (double)operand2;
                        break;
                    default:
                        MessageBox.Show(wrongInputMessage);
                        break;
                }
            }
        }
    }
}
