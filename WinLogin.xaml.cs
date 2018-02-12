using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfManageRockGroups
{
    /// <summary>
    /// Логика взаимодействия для WinLogin.xaml
    /// </summary>
    public partial class WinLogin : Window
    {
        private bool flag = false;
        public WinLogin()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = !flag;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textPass.Password != "123")
            {
                MessageBox.Show("Невірно набраний пароль", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                flag = true;
                Close();
            }

        }
    }
}
