﻿using System;
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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void BackToMainButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow pw = new MainWindow();
            pw.Show();
            this.Close();
        }

        private void CheckPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            string password = "пароль";
            if (PasswordBox.Text == password)
                MessageBox.Show("Всё правильно! Сказано же было - ввести пароль!");
            else
                MessageBox.Show("Введено не \"пароль\". Попробуйте ещё раз");
        }
    }
}
