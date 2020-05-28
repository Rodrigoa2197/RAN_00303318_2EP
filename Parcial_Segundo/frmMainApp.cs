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
    }
}