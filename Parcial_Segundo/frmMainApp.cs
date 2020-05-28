using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Parcial_Segundo
{
    public partial class frmMainApp : Form
    {
        private User user;
        public frmMainApp(User pUser)
        {
            InitializeComponent();
            user = pUser;
            
        }

        private void frmMainApp_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullNameUser.Text == "" || txtUserNameUser.Text == "" || txtUserPassword.Text == "" || Convert.ToBoolean(rbAdmin.Text) == false || Convert.ToBoolean(rbUser.Text) == false)
                {
                    MessageBox.Show("¡AVISO: Datos se detectaron campos vacios!",
                        "HUGO APP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (rbAdmin.Checked is true)
                    {
                        user.userType = true;
                    }
                    else
                    {
                        user.userType = false;
                    }

                    UserDataAccess.NewUser(txtIdUser.TextLength, txtFullNameUser.Text, txtUserNameUser.Text, txtUserPassword.Text, Convert.ToBoolean(rbAdmin.Text));

                    MessageBox.Show("SUCESS: Usuario agregado con exito!",
                        "HUGO APP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdUser.Clear();
                    txtFullNameUser.Clear();
                    txtUserNameUser.Clear();
                    txtUserPassword.Clear();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("¡AVISO: Datos invalidos!",
                    "HUGO APP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserDataAccess.ActualizarPassword(txtUserNameUser.Text, txtUserPassword.Text);
           
            MessageBox.Show("¡SUCCESS: Contraseña Actualizada!",
                "HUGO APP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnModificarDireccion_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnEliminarDireccion_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnAddBusiness_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnDeleteBusiness_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnCreateUserAdmin_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnEliminateUserAdmin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("AVISO: ¿Esta seguro de eliminar el usuario?",
                "HUGO APP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UserDataAccess.EliminarUsuario(txtEliminateUserAdmin.Text);
            
                MessageBox.Show("SUCCESS: Usuario eliminado exitosamente",
                    "HUGO APP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdateDataViewUsers_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnUpdateOrderAdmin_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnConsultOrderUser_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnCreateUserAdmin_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtFullNameUser.Text == "" || txtUserNameUser.Text == "" || txtUserPassword.Text == "" )
                {
                    MessageBox.Show("¡AVISO: Datos se detectaron campos vacios!",
                        "HUGO APP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (rbAdmin.Checked is true)
                    {
                        user.userType = true;
                    }
                    else
                    {
                        user.userType = false;
                    }

                    UserDataAccess.NewUser(txtIdUser.TextLength, txtFullNameUser.Text, txtUserNameUser.Text, txtUserPassword.Text, Convert.ToBoolean(rbAdmin.Text));

                    MessageBox.Show("SUCESS: Usuario agregado con exito!",
                        "HUGO APP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdUser.Clear();
                    txtFullNameUser.Clear();
                    txtUserNameUser.Clear();
                    txtUserPassword.Clear();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("¡AVISO: Datos invalidos!",
                    "HUGO APP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserNameUser_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}