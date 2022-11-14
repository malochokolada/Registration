using RegistrationWindow.View.Pages;
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

namespace RegistrationWindow
{
    /// <summary>
    /// Логика взаимодействия для TimetableWindow.xaml
    /// </summary>
    public partial class TimetableWindow : Window
    {
        public TimetableWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new TimeTablePage());

        }

        private void TimeTable_Click(object sender, RoutedEventArgs e)
        {
            
               MainFrame.Navigate(new TimeTablePage());
            
        }

        private void TeacherButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TeacherPage());
        }
    }
}
