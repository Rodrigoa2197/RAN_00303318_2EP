using Preparcial.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Preparcial.Controlador
{
    public static class ControladorInventario
    {
        // Metodo encargado de devolver un DataTable con todos los elementos del inventario
        public static DataTable GetProductosTable()
        {
            DataTable productos = null;

            // Solamente la consulta y conexion a la BD van en el try, ya que lo demas no puede ocasionar excepcion
            try
            {
                productos = ConexionBD.EjecutarConsulta("SELECT * FROM INVENTARIO");
            }
            catch(Exception ex)
            {
                MessageBox.Show("AVISO: Ha ocurrido un error");
            }

            return productos;
        }

        // Metodo que devuelve los productos en formato de List
        public static List<Inventario> GetProductos()
        {
            // Declaracion de lista y DataTable
            var productos = new List<Inventario>();
            DataTable dt = null;

            try
            {
                // Consulta para llenar el DataTable
                dt = ConexionBD.EjecutarConsulta("SELECT * FROM INVENTARIO");

                // Por cada fila del DataTable, crear un nuevo usuario anadiendolo a la lista
                foreach(DataRow dr in dt.Rows)
                {
                    productos.Add(new Inventario
                        (
                            dr[0].ToString(),//Se ha cambiado la propiedad de string a int al id articulo, ya que en la bd es declarado como int no string  pero dio error se volvio a su estado original
                            dr[1].ToString(),
                            dr[2].ToString(),
                            dr[3].ToString(),
                            dr[4].ToString()//Se habia cambiado la propiedad de string a int al stock, ya que en la bd es declarado como int no string pero dio error se volvio a su estado original
                        )
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AVISO: Ha ocurrido un error");
            }

            return productos;
        }

        // Metodo para anadir productos
        public static void AnadirProducto(string producto, string descripcion, string precio, string stock)// Se ha modificado el "string stock a int stock" para que se almacene de manera correcta en la bd
        {
            try
            {
                ConexionBD.EjecutarComando("INSERT INTO INVENTARIO(nombreArt, descripcion, precio, stock)" + // se modificio la declaracion nombreArticulo a nombreArt
                    $" VALUES('{producto}', '{descripcion}', '{precio}', '{stock}')");

                MessageBox.Show("SUCCESS: Se ha agregado el producto");
            }
            catch (Exception ex)
            {
                MessageBox.Show("AVISO: Ha ocurrido un error");
            }
        }

        // Metodo para eliminar productos
        public static void EliminarProducto(string idArticulo)
        {
            try
            {
                ConexionBD.EjecutarComando($"DELETE FROM INVENTARIO WHERE idArticulo = {idArticulo}");

                MessageBox.Show("SUCCESS: Se ha eliminado el producto");
            }
            catch (Exception ex)
            {
                MessageBox.Show("AVISO: Ha ocurrido un error");
            }
        }

        // Metodo para actualizar stock de un producto
        public static void ActualizarProducto(string idArticulo, string stock)
        {
            try
            {
                ConexionBD.EjecutarComando($"UPDATE INVENTARIO SET stock = {stock} WHERE idArticulo = {idArticulo}");

                MessageBox.Show("SUCCESS: Se ha actualizado el producto");
            }
            catch (Exception ex)
            {
                MessageBox.Show("AVISO: Ha ocurrido un error");
            }
        }
    }
}
