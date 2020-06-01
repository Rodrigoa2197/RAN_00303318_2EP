using System.Data;
using System.Collections.Generic;
using Preparcial.Modelo;
using System;
using System.Windows.Forms;

namespace Preparcial.Controlador
{
    public static class ControladorUsuario
    {
        public static List<Usuario> GetUsuarios()
        {
            var usuarios = new List<Usuario>();
            DataTable tableUsuarios = null;

            try
            {
                tableUsuarios = ConexionBD.EjecutarConsulta("SELECT * FROM USUARIO");
            }
            catch(Exception ex)
            {
                MessageBox.Show("AVISO: Ha ocurrido un error");
            }

            foreach(DataRow dr in tableUsuarios.Rows)
            {
                usuarios.Add(new Usuario
                    (
                        dr[0].ToString(), //Al principio cambie esto a convert.Toint32 y no me agarro el "idUsuario:", como tendría que ser y por ello deje el atributo "idUsuario" declarado como string
                        dr[1].ToString(),
                        dr[2].ToString(),
                        Convert.ToBoolean(dr[3].ToString())
                    )
                );
            }

            return usuarios;
        }

        public static DataTable GetUsuariosTable()
        {
            DataTable tableUsuarios = null;

            try
            {
                tableUsuarios = ConexionBD.EjecutarConsulta("SELECT * FROM USUARIO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("AVISO: Ha ocurrido un error");
            }

            return tableUsuarios;
        }

        public static void ActualizarContrasena(string idUsuario, string contrasenia)
        {
            try
            {
                ConexionBD.EjecutarComando($"UPDATE USUARIO SET contrasenia = '{contrasenia}' " +
                    $"WHERE idUsuario = {idUsuario}"); // se ha modificado para que se almacene de manera correcta la contraseña 
                MessageBox.Show("SUCESS: Se ha actualizado la contrasena");
            }
            catch(Exception ex)
            {
                MessageBox.Show("AVISO: Ha ocurrido un error");
            }
        }

        public static void CrearUsuario(string nombre)
        {
            try
            {
                ConexionBD.EjecutarComando("INSERT INTO USUARIO(nombre, contrasenia, tipo)" + //Se ha modificado inset into USUARIO los parametros para que se alamacene de manera correcta en la base de datos
                    $" VALUES('{nombre}', '{nombre}', false)");

                MessageBox.Show("SUCESS: Se ha agregado el nuevo usuario, contrasenia igual al nombre");
            }
            catch(Exception ex)
            {
                MessageBox.Show("AVISO: Ha ocurrido un error");
            }
        }
    }
}
