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


namespace Agenda_OS_Diego.Classes
{
    class BD
    {   //conexão com banco de dados
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

    class CRUD : BD
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

        //Read Properties
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        //CREATE dados
        public void Criar_Dados()
        {
            con.Open();
            string CommandText = "INSERT INTO empresa VALUES (0, @razao, @fantasia, @cnpj, @rua, @bairro, @cidade, @numero, @cep, @telefone, @celular) ";
            MySqlCommand cmd = new MySqlCommand(CommandText, con);

            cmd.Parameters.AddWithValue("@razao", razao);
            cmd.Parameters.AddWithValue("@fantasia", fantasia);
            cmd.Parameters.AddWithValue("@cnpj", cnpj);
            cmd.Parameters.AddWithValue("@rua", rua);
            cmd.Parameters.AddWithValue("@bairro", bairro);
            cmd.Parameters.AddWithValue("@cidade", cidade);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@cep", cep);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@celular", celular);
            MessageBox.Show("Cadastrado com sucesso!");
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.Close();

        }

        //UPDATE alterar dados
        public void Alterar_Dados()
        {
            con.Open();
            string query = "UPDATE empresa SET razao=@razao, fantasia=@fantasia, cnpj=@cnpj, rua=@rua, bairro=@bairro, cidade=@cidade, numero=@numero, cep=@cep, telefone=@telefone, celular=@celular WHERE id=@id ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@razao", razao);
            cmd.Parameters.AddWithValue("@fantasia", fantasia);
            cmd.Parameters.AddWithValue("@cnpj", cnpj);
            cmd.Parameters.AddWithValue("@rua", rua);
            cmd.Parameters.AddWithValue("@bairro", bairro);
            cmd.Parameters.AddWithValue("@cidade", cidade);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@cep", cep);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@celular", celular);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Alterado com sucesso");

            cmd.Parameters.Clear();
            con.Close();
        }

        //DELETE dados
        public void Deletar_Dados(string id)
        {
            con.Open();
            string query = "DELETE FROM empresa WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deletado com sucesso!");
            cmd.Parameters.Clear();
            con.Close();
        }

        //Listar datagridview
        public void Listar_Dados(DataGridView dgv)
        {
            con.Open();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT * FROM empresa";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, con);
            DataTable table = new DataTable();
            MyDA.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv.DataSource = bSource;
            con.Close();
        }

        //pesquisa em tempo real no datagridview
        public void Listar_Dados_Especificos(DataGridView DGV, string razao)
        {
            con.Open();
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT * FROM empresa WHERE razao LIKE '%" + razao.ToString() + "%'";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, con);
            DataTable table = new DataTable();
            MyDA.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            DGV.DataSource = bSource;
            con.Close();
        }


    }
}
