using System;

namespace Parcial_Segundo
{
    public class ProductDataAccess
    {
        public static void CrearNuevo(Product producto)
        {
            string sql = String.Format("INSERT INTO product(idProduct, idBusiness, name) VALUES ({0}, {1}, {2});",
                producto.idProduct, producto.idBusiness,producto.name);
            
            ConnectionDB.ExecuteNonQuery(sql);
        }
        
        
    }
}