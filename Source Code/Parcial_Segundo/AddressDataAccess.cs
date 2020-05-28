using System;
namespace Parcial_Segundo
{
    public class AddressDataAccess
    {
        public static void CrearNuevo(Address direccion)
        {
            string sql = String.Format("INSERT INTO address(idAddress, idUser, address) VALUES ({0}, {1}, {2});",
                direccion.idAddress, direccion.idUser, direccion.address);

            ConnectionDB.ExecuteNonQuery(sql);
        }
    }
}