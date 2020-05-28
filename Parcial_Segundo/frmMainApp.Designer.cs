using System.ComponentModel;

namespace Parcial_Segundo
{
    partial class frmMainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabUser = new System.Windows.Forms.TabControl();
            this.tabUsuario = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPasswordUser = new System.Windows.Forms.TextBox();
            this.txtUserNameUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullNameUser = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbUser = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.tabAddress = new System.Windows.Forms.TabPage();
            this.tabBusiness = new System.Windows.Forms.TabPage();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.tabProductsAmin = new System.Windows.Forms.TabPage();
            this.tabProductosUser = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabUser.SuspendLayout();
            this.tabUsuario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.tabUsuario);
            this.tabUser.Controls.Add(this.tabAdmin);
            this.tabUser.Controls.Add(this.tabAddress);
            this.tabUser.Controls.Add(this.tabBusiness);
            this.tabUser.Controls.Add(this.tabProducts);
            this.tabUser.Controls.Add(this.tabProductsAmin);
            this.tabUser.Controls.Add(this.tabProductosUser);
            this.tabUser.Location = new System.Drawing.Point(32, 102);
            this.tabUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUser.Name = "tabUser";
            this.tabUser.SelectedIndex = 0;
            this.tabUser.Size = new System.Drawing.Size(1046, 581);
            this.tabUser.TabIndex = 0;
            // 
            // tabUsuario
            // 
            this.tabUsuario.BackColor = System.Drawing.Color.White;
            this.tabUsuario.BackgroundImage = global::Parcial_Segundo.Properties.Resources.logo_mainbackground;
            this.tabUsuario.Controls.Add(this.groupBox1);
            this.tabUsuario.Location = new System.Drawing.Point(4, 29);
            this.tabUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUsuario.Size = new System.Drawing.Size(1038, 548);
            this.tabUsuario.TabIndex = 0;
            this.tabUsuario.Text = "Usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(49, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(927, 502);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrarse";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.txtPasswordUser, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUserNameUser, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFullNameUser, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(724, 478);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // txtPasswordUser
            // 
            this.txtPasswordUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPasswordUser.Location = new System.Drawing.Point(258, 384);
            this.txtPasswordUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordUser.Name = "txtPasswordUser";
            this.txtPasswordUser.Size = new System.Drawing.Size(425, 27);
            this.txtPasswordUser.TabIndex = 5;
            // 
            // txtUserNameUser
            // 
            this.txtUserNameUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserNameUser.Location = new System.Drawing.Point(258, 225);
            this.txtUserNameUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserNameUser.Name = "txtUserNameUser";
            this.txtUserNameUser.Size = new System.Drawing.Size(425, 27);
            this.txtUserNameUser.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Unispace", 16.2F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 159);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Unispace", 16.2F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(3, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 160);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Unispace", 16.2F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(3, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 159);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Usuario:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFullNameUser
            // 
            this.txtFullNameUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFullNameUser.Location = new System.Drawing.Point(258, 66);
            this.txtFullNameUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFullNameUser.Name = "txtFullNameUser";
            this.txtFullNameUser.Size = new System.Drawing.Size(425, 27);
            this.txtFullNameUser.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(761, 252);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 64);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cambiar Contraseña";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(761, 176);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = "Registrarse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbUser);
            this.groupBox2.Controls.Add(this.rbAdmin);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox2.Location = new System.Drawing.Point(733, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(188, 120);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo";
            // 
            // rbUser
            // 
            this.rbUser.Location = new System.Drawing.Point(28, 25);
            this.rbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(126, 30);
            this.rbUser.TabIndex = 0;
            this.rbUser.TabStop = true;
            this.rbUser.Text = "Usuario";
            this.rbUser.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.Location = new System.Drawing.Point(28, 70);
            this.rbAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(126, 30);
            this.rbAdmin.TabIndex = 1;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Administrador";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // tabAdmin
            // 
            this.tabAdmin.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))),
                ((int) (((byte) (192)))));
            this.tabAdmin.BackgroundImage = global::Parcial_Segundo.Properties.Resources.logo_mainbackground1;
            this.tabAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabAdmin.Controls.Add(this.groupBox3);
            this.tabAdmin.Location = new System.Drawing.Point(4, 29);
            this.tabAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdmin.Size = new System.Drawing.Size(1038, 548);
            this.tabAdmin.TabIndex = 1;
            this.tabAdmin.Text = "Administrador";
            // 
            // tabAddress
            // 
            this.tabAddress.BackColor = System.Drawing.Color.Purple;
            this.tabAddress.BackgroundImage = global::Parcial_Segundo.Properties.Resources.logo_mainbackground;
            this.tabAddress.Location = new System.Drawing.Point(4, 25);
            this.tabAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAddress.Name = "tabAddress";
            this.tabAddress.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAddress.Size = new System.Drawing.Size(1038, 552);
            this.tabAddress.TabIndex = 2;
            this.tabAddress.Text = "Direcciones";
            // 
            // tabBusiness
            // 
            this.tabBusiness.BackgroundImage = global::Parcial_Segundo.Properties.Resources.logo_mainbackground;
            this.tabBusiness.Location = new System.Drawing.Point(4, 25);
            this.tabBusiness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBusiness.Name = "tabBusiness";
            this.tabBusiness.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBusiness.Size = new System.Drawing.Size(1038, 552);
            this.tabBusiness.TabIndex = 3;
            this.tabBusiness.Text = "Negocios";
            this.tabBusiness.UseVisualStyleBackColor = true;
            // 
            // tabProducts
            // 
            this.tabProducts.BackgroundImage = global::Parcial_Segundo.Properties.Resources.logo_mainbackground1;
            this.tabProducts.Location = new System.Drawing.Point(4, 25);
            this.tabProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProducts.Size = new System.Drawing.Size(1038, 552);
            this.tabProducts.TabIndex = 4;
            this.tabProducts.Text = "Pedidos";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // tabProductsAmin
            // 
            this.tabProductsAmin.BackgroundImage = global::Parcial_Segundo.Properties.Resources.logo_mainbackground1;
            this.tabProductsAmin.Location = new System.Drawing.Point(4, 25);
            this.tabProductsAmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProductsAmin.Name = "tabProductsAmin";
            this.tabProductsAmin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProductsAmin.Size = new System.Drawing.Size(1038, 552);
            this.tabProductsAmin.TabIndex = 5;
            this.tabProductsAmin.Text = "Ordenes(Administrador)";
            this.tabProductsAmin.UseVisualStyleBackColor = true;
            // 
            // tabProductosUser
            // 
            this.tabProductosUser.BackgroundImage = global::Parcial_Segundo.Properties.Resources.logo_mainbackground1;
            this.tabProductosUser.Location = new System.Drawing.Point(4, 25);
            this.tabProductosUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProductosUser.Name = "tabProductosUser";
            this.tabProductosUser.Size = new System.Drawing.Size(1038, 552);
            this.tabProductosUser.TabIndex = 6;
            this.tabProductosUser.Text = "Ordenes(Usuario)";
            this.tabProductosUser.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Parcial_Segundo.Properties.Resources.logo_mainbackground;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(32, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 78);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))),
                ((int) (((byte) (192)))));
            this.pictureBox2.BackgroundImage = global::Parcial_Segundo.Properties.Resources.logo_app;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(961, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 81);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = global::Parcial_Segundo.Properties.Resources.pidamos_hugo;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(375, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(117, 81);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(85, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(863, 464);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // frmMainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parcial_Segundo.Properties.Resources.background_app;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 708);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabUser);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMainApp";
            this.Text = "¡Bienvenido a HUGO!";
            this.Load += new System.EventHandler(this.frmMainApp_Load);
            this.tabUser.ResumeLayout(false);
            this.tabUsuario.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabUser;
        private System.Windows.Forms.TabPage tabAdmin;
        private System.Windows.Forms.TabPage tabUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabAddress;
        private System.Windows.Forms.TabPage tabProductosUser;
        private System.Windows.Forms.TabPage tabProductsAmin;
        private System.Windows.Forms.TabPage tabBusiness;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rbUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullNameUser;
        private System.Windows.Forms.TextBox txtUserNameUser;
        private System.Windows.Forms.TextBox txtPasswordUser;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}