using System;
using System.Collections.Generic;
using System.Data;
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
            string sql = "SELECT * FROM BUSINESS";

            DataTable dt = ConnectionDB.ExecuteQuery(sql);

            List<Business> lista = new List<Business>();

            foreach (DataRow row in dt.Rows)
            {
                Business add = new Business();
                add.idBusiness = Convert.ToInt32(row[0].ToString());
                add.name = row[1].ToString();
                add.description = row[2].ToString();
                lista.Add(add);
            }

            cmbNombreNegocioPedido.ValueMember = "idBusiness";
            cmbNombreNegocioPedido.DisplayMember = "name";
            cmbNombreNegocioPedido.DataSource = lista;
            try
            {
                sql = "SELECT * FROM APPUSER";
                dt = ConnectionDB.ExecuteQuery(sql);
                dataGridViewOrderAdmin.DataSource = dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show("AVISO: Ha ocurrido un error");
            }
            try
            {
                sql = "SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au WHERE ao.idProduct = pr.idProduct AND ao.idAddress = ad.idAddress AND ad.idUser = au.idUser";
                dt = ConnectionDB.ExecuteQuery(sql);
                dataGridViewOrderAdmin.DataSource = dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbAdmin.Checked)
                {
                    
                    UserDataAccess.NewUser(txtFullNameUser.Text, txtUserNameUser.Text, txtUserPassword.Text, rbAdmin.Checked);

                    MessageBox.Show("SUCESS: El Admin ha sido agregado con exito!",
                        "HUGO APP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFullNameUser.Clear();
                    txtUserNameUser.Clear();
                    txtUserPassword.Clear();
                }
                else if(rbUser.Checked)
                {
                     
                    UserDataAccess.NewUser(txtFullNameUser.Text, txtUserNameUser.Text, txtUserPassword.Text, rbUser.Checked);

                    MessageBox.Show("SUCESS: El Usuario ha sido agregado con exito!",
                        "HUGO APP", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txtNameBusiness.Text.Equals("") || txtDescripcionBusiness.Text.Equals(""))
            {
                MessageBox.Show("¡AVISO: Debe de ingresar información en todos los campos!");
            }
            else
            {
                try
                {
                    AddBusinessVerification(txtNameBusiness.Text, txtDescripcionBusiness.Text);
                }
                catch(Exception)
                {
                    MessageBox.Show("¡AVISO: Ha ocurrido un error!");
                }
            }
            void AddBusinessVerification(String name, String description)
            {
                string sql = $"INSERT INTO BUSINESS(name, description) VALUES ('{name}', '{description}')";
                ConnectionDB.ExecuteQuery(sql);
                MessageBox.Show("SUCCESS: Negocio añadido exitosamente");
            }
        }

        private void btnDeleteBusiness_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de eliminar el producto?",
                "HUGO APP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BusinessDataAccess.EliminarBusiness(txtDeleteBusiness.Text);

                MessageBox.Show("SUCESS: Producto eliminado exitosamente",
                    "HUGO APP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtAddProductName.Text.Equals(""))
            {
                MessageBox.Show("¡AVISO: Debe de ingresar información en todos los campos!");
            }
            else
            {
                try
                {
                    string sql = $"INSERT INTO PRODUCT(idBusiness, name) VALUES({cmbNombreNegocioPedido.SelectedValue}, '{txtAddProductName.Text}')";
                    ConnectionDB.ExecuteQuery(sql);
                }
                catch(Exception)
                {
                    MessageBox.Show("¡AVISO: Ha ocurrido un error!");
                }
            }
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
            try
            {
                SearchVerification(btnUpdateOrderAdmin.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        public void SearchVerification(String a)
        {
            try
            {
                int number = Convert.ToInt32(a);
                bool idExist = false;
                string sql = "SELECT idUser FROM APPUSER";
                DataTable dt = ConnectionDB.ExecuteQuery(sql);
                foreach (DataRow row in dt.Rows)
                {
                    if (Convert.ToInt32(row[0].ToString()) == number)
                    {
                        string sqlSearch = $"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au WHERE ao.idProduct = pr.idProduct AND ao.idAddress = ad.idAddress AND ad.idUser = au.idUser AND au.idUser = {number}";
                        DataTable dtSearch = ConnectionDB.ExecuteQuery(sqlSearch);
                        dataGridViewOrderAdmin.DataSource = dtSearch;
                        idExist = true;
                    }
                }
                if (!idExist)
                {
                    throw new Exception("AVISO: Debe de ingresar un ID válido");
                }
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            
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
                if(rbUserAdmin.Checked)
                {
                     
                    UserDataAccess.NewUser(txtFullNameUser.Text, txtUserNameUser.Text, txtUserPassword.Text, rbUserAdmin.Checked);

                    MessageBox.Show("SUCESS: El Usuario ha sido agregado con exito!",
                        "HUGO APP", MessageBoxButtons.OK, MessageBoxIcon.Information);
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