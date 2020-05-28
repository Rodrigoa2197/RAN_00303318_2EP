namespace Parcial_Segundo
{
    public class BusinessDataAccess
    {
        public static void EliminarBusiness(string nombre)
        {
            string sql = string.Format(
                "DELETE FROM Business WHERE name='{0}';",
                nombre);

            ConnectionDB.ExecuteNonQuery(sql);
        }
    }
}