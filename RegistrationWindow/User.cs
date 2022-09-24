using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationWindow
{
    internal class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public static ObservableCollection<User> GetUserList()
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
                else return false;
            }
            return false;
        }
    }
}
