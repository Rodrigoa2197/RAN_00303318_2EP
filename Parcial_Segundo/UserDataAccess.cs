using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial_Segundo
{
    public class UserDataAccess
    {
        public static User GetUser(String nombre, String contra)
        {
            string sql = String.Format("SELECT * FROM appuser WHERE nombre = '{0}' AND contrasenia = '{1}';", nombre, contra);

            DataTable dt = ConnectionDB.ExecuteQuery(sql);

                User add = new User();
                foreach (DataRow fila in dt.Rows)
                {
                    add.fullname = fila[0].ToString();
                    add.username = fila[1].ToString();
                    add.password = fila[2].ToString();
                    add.type = Convert.ToBoolean(fila[3].ToString());
                }
            return add;
        }

        public static List<User> GetLista()
        {
            string sql = "SELECT * FROM appuser";

            DataTable dt = ConnectionDB.ExecuteQuery(sql);
            
            List<User> lista = new List<User>();
            foreach (DataRow fila in dt.Rows)
            {
                User add = new User();
                add.fullname = fila[0].ToString();
                add.username = fila[1].ToString();
                add.password = fila[2].ToString();
                add.type = Convert.ToBoolean(fila[3].ToString());
                lista.Add(add);
            }

            return lista;
        }
        public static void NewUser(string fullname, string username, string password, bool type)
        {
            string sql = String.Format(
                "INSERT INTO appuser(fullname, username, password, userType) VALUES ('{0}', '{1}', '{2}', '{true}');",
                fullname, username, password, type);

                ConnectionDB.ExecuteNonQuery(sql);
        }
        public static void ActualizarPermiso(string username, bool userType)
        {
            string sql = string.Format(
                "UPDATE appuser SET userType='{true}' WHERE username='{1}';",
                userType, username);
            
            ConnectionDB.ExecuteNonQuery(sql);
        }
        public static void ActualizarPassword(string username, string password)
        {
            string sql = string.Format(
                "UPDATE appuser SET password='{0}' WHERE username='{1}';",
                username, password);
            
            ConnectionDB.ExecuteNonQuery(sql);
        }

        public static void EliminarUsuario(string username)
        {
            string sql = string.Format(
                "DELETE FROM appuser WHERE username='{0}';",
                username);
            
            ConnectionDB.ExecuteNonQuery(sql);
        }
    }
}