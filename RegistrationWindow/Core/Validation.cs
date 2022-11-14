using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationWindow
{
    public static class Validation
    {
            public static bool ValidationMetod(User user)
            {
            var listUsers = User.GetListUsers();
            foreach (User userOne in listUsers)
            {
             if (user.Login == userOne.Login && user.Password == userOne.Password) return true;
            }
               return false;


            /* if (user.Password == "1234" && user.Login == "V") return true;
             else return false;*/
        }
        
        

    }
}
