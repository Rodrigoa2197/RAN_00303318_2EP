using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_Segundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                var user = UserDataAccess.GetUser(txtLogUser.Text, txtLoginContra.Text);
                if (user.type is true)
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos","Hugo App",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Bienvenido","HUGO App",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                    frmMainApp ventana = new frmMainApp(user);
                    ventana.Show();
                    this.Hide();
                
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea Cerrar la Aplicación?", 
                "HUGO App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}