using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationWindow
{
    public class User
    {
        private string _login;       //поле
        private string _password;    //поле
        public string Login { get => _login; set => _login = value; }       //Свойство
        public string Password { get =>_password; set => _password = value; }   //Свойство


        public static ObservableCollection<User> GetListUsers()
        {
            var ListUsers = new ObservableCollection<User>()
            {
                new User()
                {
                    Login = "Potato",
                    Password = "4673"
                },

                new User()
                {
                    Login = "Whatermelon",
                    Password = "4215"
                },

                new User()
                {
                    Login = "Aaron",
                    Password = "42318"
                },

                new User()
                {
                    Login = "Dan",
                    Password = "0939"
                }


            };
            return ListUsers;
        }

        public User()
        {

        }


        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

       

        /* public static ObservableCollection<User> GetUserList()
        {
            var userList = new ObservableCollection<User>()
            {
                new User()
                {
                    Login = "p302",
                    Password= "k80v"
                }
            };

            return userList;
        }

        public bool VerificationUser( string Login, string Passvord)
        {
            foreach (var user in GetUserList())
            {
                if (user.Login == Login && (user.Password == Passvord))
                    return true;
                 return false;
            }
           return false;
        }*/
    }
}

