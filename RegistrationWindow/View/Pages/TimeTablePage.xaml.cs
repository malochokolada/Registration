﻿using RegistrationWindow.ViewModel;
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
    /// Логика взаимодействия для TimeTablePage.xaml
    /// </summary>
    public partial class TimeTablePage : Page
    {
        public TimeTablePage()
        {
            InitializeComponent();
            (DataContext as TimetablePageViewModel).FileReader();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as TimetablePageViewModel).ListViewFill(TeacherBox.SelectedItem, SubjectsBox.SelectedItem);

        }
    }
}
