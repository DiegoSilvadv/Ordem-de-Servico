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
using Agenda_OS_Diego.Database;


namespace Agenda_OS_Diego.LoginUsuarios
{
    class LoginUsuario : DataBase
    {
        DataBase DB = new DataBase();

        public DataTable usuarioDT { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public string logado { get; set; }
        
        //Validação do login
        public void  ConsultarLogin() 
        {
            try
            {
                DB.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand("SELECT usuario, senha FROM tecnico WHERE usuario=@usuario AND senha = @senha", DB.con);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    this.logado = "Logado";
                    DB.FecharConexao();
                }
                else {
                    this.logado = "Negado";
                    DB.FecharConexao();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.FecharConexao();
            }
        }
        
        //Lista os usuários no combo box
        public void ListarUsuario()
        {
            try {
                DB.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand("SELECT id_tecnico, usuario FROM tecnico ORDER BY usuario", DB.con);
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                this.usuarioDT = dt;
                DB.FecharConexao();
            }
            catch (Exception error) {
                MessageBox.Show(error.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.FecharConexao();
            }
           
        }
    }
}
