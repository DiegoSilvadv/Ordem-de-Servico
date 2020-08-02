using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
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
            public void ListarComboBox(string combo) {

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT CourseId,CourseName FROM Courses", conn);

                cmd.CommandType = CommandType.Text;

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    this.courseComboBox.DisplayMember = dr[0];
                    this.courseComboBox.ValueMember = dr[1];
                    this.courseComboBox.DataSource = dr;

                    dr.Close();


                    con.Close();
            
            
            }









        }
        public Login()
        {
            InitializeComponent();
        }

        
    }
}
