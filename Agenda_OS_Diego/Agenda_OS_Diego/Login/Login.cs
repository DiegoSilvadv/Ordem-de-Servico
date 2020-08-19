using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Serialization;
using Agenda_OS_Diego.LoginUsuarios;

namespace Agenda_OS_Diego.Login
{
    public partial class Login : Form
    {
        LoginUsuario loginUsuario = new LoginUsuario();
        
        public Login()
        {
            InitializeComponent();
        }

      

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btn_login_Click_1(object sender, EventArgs e)
        {

            Home frmHome = new Home();
            this.Hide();
            frmHome.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
