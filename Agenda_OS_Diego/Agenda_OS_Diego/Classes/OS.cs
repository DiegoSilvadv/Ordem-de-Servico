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
            public string tecnico { set; get; }
            public string solicitante { set; get; }
            public string fantasia { set; get; }
            public string cnpj { set; get; }
            public string telefone { set; get; }
            public string celular { set; get; }
            public string informação_extra { set; get; }
            public string assunto { set; get; }
            public string descricao { set; get; }
            public string atendimento { set; get; }
            public string sistema{ set; get; }
            public string solucao { set; get; }
            public string abertura { set; get; }
            public string conclusao { set; get; }
            public string status { set; get; }

        public void Listar_Dados(DataGridView dgv)
        {
            con.Open();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT * FROM ordemservico";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, con);
            DataTable table = new DataTable();
            MyDA.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv.DataSource = bSource;

            con.Close();
        }


        public void ListarEmpresa() {

            MySqlCommand cmd = new MySqlCommand("SELECT  fantasia, cnpj, telefone FROM empresa WHERE fantasia like '%'@fantasia'%'", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@fantasia", fantasia);

            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                {
                MessageBox.Show("Empresa" + fantasia);
                    this.fantasia = dr["fantasia"].ToString();
                    this.cnpj = dr["cnpj"].ToString();
                    this.telefone = dr["telefone"].ToString();
                }
            con.Close();



        }

    }
    }

