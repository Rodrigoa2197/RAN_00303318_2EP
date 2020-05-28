using System;

namespace Parcial_Segundo
{
    public class User
    {
        public int idUser { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool userType { get; set; }

        public User()
        {
            idUser = -1;
            fullname = "";
            username = "";
            password = "";
            userType = false;
        }
    }
}