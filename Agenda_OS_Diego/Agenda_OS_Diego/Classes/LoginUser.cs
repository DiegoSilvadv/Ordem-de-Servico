using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization;
using Agenda_OS_Diego.Login;

namespace Agenda_OS_Diego.LoginUsuarios
{
    class BD
    {   
        //conexão com banco de dados
        public MySqlConnection con;

        public BD()
        {
            string host = "localhost";
            string db = "agenda";
            string port = "3306";
            string user = "root";
            string pass = " ";
            string constring = "datasource =" + host + "; database=" + db + "; port=" + port + "; username=" + user + "; password=" + pass + "; SslMode=none";
            con = new MySqlConnection(constring);
        }
    }

    class LoginUsuario : BD
    {
       

        

    }
}
