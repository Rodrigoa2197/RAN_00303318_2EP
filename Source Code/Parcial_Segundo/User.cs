using System;

namespace Parcial_Segundo
{
    public class User
    {
        public string fullname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool userType { get; set; }

        public User()
        {
            fullname = "";
            username = "";
            password = "";
            userType = false;
        }
    }
}