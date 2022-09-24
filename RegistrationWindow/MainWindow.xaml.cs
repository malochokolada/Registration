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

namespace RegistrationWindow
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

       

        private void signInButton(object sender, RoutedEventArgs e)
        {
            string Login,
                Password;
            Login = loginBox.Text;
            Password = passwordBox.Text;
            User user = new User();
            bool result = user.VerificationUser(Login, Password);
            if (result == true)
            {
                TimetableWindow Ttw = new TimetableWindow();
                Ttw.Show();
                this.Close();
            }
            else
                MessageBox.Show("Повторите попытку.", "Ошибка авторизаци.", MessageBoxButton.OK , MessageBoxImage.Error);
        }
    }
}
