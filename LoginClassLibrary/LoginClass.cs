using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoginClassLibrary
{
    public class LoginClass
    {
        public bool login(String UserName,String Password)
        {
            if (UserName == "Admin" && Password == "Admin")
                return true;
            else
                return false;
        }
    }
}
