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
        public string usuario { get; set; }
        public string senha { get; set; }
        public string logado { get; set; }
        public void  ConsultarLogin() 
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT usuario, senha FROM tecnico WHERE usuario=@usuario AND senha = @senha", con);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    this.logado = "Logado";
                    con.Close();
                    MessageBox.Show("olaaa" + usuario);
                }
                else {
                    this.logado = "Negado";
                    con.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }


            MessageBox.Show("" + usuario);


        }
        

    }
}
