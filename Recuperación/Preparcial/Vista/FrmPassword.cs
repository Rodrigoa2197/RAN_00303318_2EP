using Preparcial.Controlador;
using Preparcial.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preparcial.Vista
{
    public partial class FrmPassword : Form
    {
        public FrmPassword()
        {
            InitializeComponent();
        }

        private void FrmPassword_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("../../Recursos/UCA.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            
            ActualizarControlers();
        }

        private void ActualizarControlers()
        {
            comboBox1.ValueMember = "Contrasena"; //Se modifico para desplegar de manera correcta
            comboBox1.DataSource = ControladorUsuario.GetUsuarios();
            comboBox1.DisplayMember = "NombreUsuario"; //se modifico para desplegar de manera correcta
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text.Equals(comboBox1.SelectedValue.ToString()))
            {       
                var obtenerUsuario = (Usuario)comboBox1.SelectedItem;

                ActualizarControlers();
                                
                ControladorUsuario.ActualizarContrasena(obtenerUsuario.IdUsuario,// se modifico la variable "idUsuario a IdUsuario" declarada para que esta funcione de manera correcta en el programa
                txtNewPassword.Text);
            }
            else
            {
                MessageBox.Show("Contraseña actual incorrecta");
            }
        }
    }
}
