using RegistrationWindow.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RegistrationWindow.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private User _userLoging;

        public User UserLoging
        {
            get => _userLoging;
            set
            {
                _userLoging = value;
                OnPropertyChanged(nameof(UserLoging));
            }
        }

        public void ExitEx()
        {
            foreach (Window item in Application.Current.Windows)
            {
                if (item is MainWindow) item.Close();
            }
        }


        private void Exit(object Object) // Можно назвать по другому
        {
            ExitEx();
        }

        public ICommand ExitCommand { get; }// Можно назвать по другому



        private void Validation_Method(object Object) 
        {
            if (!string.IsNullOrWhiteSpace(UserLoging.Login) && !string.IsNullOrWhiteSpace(UserLoging.Password))
            {

            if (Validation.ValidationMetod(UserLoging))
            {
                MessageBox.Show("Авторизация прошла успешно!!!", "Успешно!", MessageBoxButton.OK);
                    TimetableWindow timetableWindow = new TimetableWindow();
                    timetableWindow.Show();
                    ExitEx();
            }
            else
            {
                MessageBox.Show("Введённые данные неверны!", "Упс! Ошибка", MessageBoxButton.OK);
            }
             
             }
            else
            {
                MessageBox.Show("Одно или несколько полей пустые", "Oшибка...", MessageBoxButton.OK);
            }
        
        }

        public ICommand ValidationCommand { get; }





        public MainWindowViewModel()
        {
            _userLoging = new User();
            ExitCommand = new RelativeCommand(Exit);
            ValidationCommand = new RelativeCommand(Validation_Method);
        }


    }







}
