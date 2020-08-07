using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Agenda_OS_Diego.Classes;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization;

namespace Agenda_OS_Diego.Classes
{   
    
        class DB
        {   //conexão com banco de dados
            public MySqlConnection con;

            public DB()
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
        
        class CrudOs : DB
        {
            public string id { set; get; }
            public string razao { set; get; }
            public string fantasia { set; get; }
            public string cnpj { set; get; }
            public string rua { set; get; }
            public string bairro { set; get; }
            public string cidade { set; get; }
            public string numero { set; get; }
            public string cep { set; get; }
            public string telefone { set; get; }
            public string celular { set; get; }

            public void ListarEmpresa() {
                con.Open();
                string sSQL = "SELECT * FROM empresa WHERE fantasia LIKE '%'@fantasia'%'";
                MySqlCommand cmd = new MySqlCommand(sSQL, con);
                cmd.Parameters.AddWithValue("@fantasia", fantasia );
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show(fantasia);
               
                con.Close();

            }
            
        }
    }

