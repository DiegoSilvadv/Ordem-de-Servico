using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Agenda_OS_Diego.Database
{
    public class DataBase
    {
        public MySqlConnection con;

        public void Banco()
        {
            string host = "localhost";
            string db = "agenda";
            string port = "3306";
            string user = "root";
            string pass = " ";
            string constring = "datasource =" + host + "; database=" + db + "; port=" + port + "; username=" + user + "; password=" + pass + "; SslMode=none";
            con = new MySqlConnection(constring);
        }

        public void AbrirConexao()
        {
            Banco();
            con.Open();
        }

        public void FecharConexao() {
            con.Close();
        }
    }
}
