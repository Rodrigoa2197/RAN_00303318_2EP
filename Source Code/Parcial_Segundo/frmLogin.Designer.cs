namespace Parcial_Segundo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtLogUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogIniciarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoginContra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Parcial_Segundo.Properties.Resources.logo_app;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(316, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 146);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Parcial_Segundo.Properties.Resources.pidamos_hugo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(286, 164);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 155);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.txtLogUser, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLogIniciarSesion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLoginContra, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 323);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 239);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtLogUser
            // 
            this.txtLogUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtLogUser.Location = new System.Drawing.Point(315, 26);
            this.txtLogUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLogUser.Name = "txtLogUser";
            this.txtLogUser.Size = new System.Drawing.Size(370, 27);
            this.txtLogUser.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 79);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogIniciarSesion
            // 
            this.btnLogIniciarSesion.BackColor = System.Drawing.Color.MediumOrchid;
            this.tableLayoutPanel1.SetColumnSpan(this.btnLogIniciarSesion, 2);
            this.btnLogIniciarSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnLogIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnLogIniciarSesion.Location = new System.Drawing.Point(3, 160);
            this.btnLogIniciarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogIniciarSesion.Name = "btnLogIniciarSesion";
            this.btnLogIniciarSesion.Size = new System.Drawing.Size(794, 77);
            this.btnLogIniciarSesion.TabIndex = 1;
            this.btnLogIniciarSesion.Text = "Iniciar Sesión";
            this.btnLogIniciarSesion.UseVisualStyleBackColor = false;
            this.btnLogIniciarSesion.Click += new System.EventHandler(this.btnLogIniciarSesion_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 79);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contraseña:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLoginContra
            // 
            this.txtLoginContra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoginContra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtLoginContra.Location = new System.Drawing.Point(315, 105);
            this.txtLoginContra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoginContra.Name = "txtLoginContra";
            this.txtLoginContra.Size = new System.Drawing.Size(370, 27);
            this.txtLoginContra.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Login - HUGO ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogIniciarSesion;
        private System.Windows.Forms.TextBox txtLogUser;
        private System.Windows.Forms.TextBox txtLoginContra;
    }
}