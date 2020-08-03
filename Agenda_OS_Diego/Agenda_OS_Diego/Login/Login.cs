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

namespace Agenda_OS_Diego.Login
{
    public partial class Login : Form
    {
        class BD
        {   //conexão com banco de dados
            public MySqlConnection con;

            public BD()
            {
                string host = "localhost";
                string db = "agenda";
                string port = "3308";
                string user = "root";
                string pass = " ";
                string constring = "datasource =" + host + "; database=" + db + "; port=" + port + "; username=" + user + "; password=" + pass + "; SslMode=none";
                con = new MySqlConnection(constring);
            }
        }

        class LOGIN:BD {
            public string id { set; get; }
            public string usuario { set; get; }
            public string senha { set; get; }

            DataTable dt = new DataTable();
          

        }
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


    }
}
