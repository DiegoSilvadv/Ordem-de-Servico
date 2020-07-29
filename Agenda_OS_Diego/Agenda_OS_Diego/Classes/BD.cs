using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

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

    class CRUD:BD 
    {
        public string id { set; get; }
        public string razao { set; get;}
        public string fantasia { set; get; }
        public string cnpj { set; get; }
        public string rua { set; get; }
        public string bairro { set; get;}
        public string cidade { set; get; }
        public string numero { set; get; }
        public string cep { set; get;}
        public string telefone { set; get;}
        public string celular { set; get;}



        //Read Properties
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();


        //CREATE
        public void Criar_Dados() 
        {

                string CommandText = "INSERT INTO empresa VALUES (null, @razao, @fantasia, @cnpj, @rua, @bairro, @cidade, @numero, @cep, @telefone, @celular) ";
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
                con.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                con.Close();
            
        }

        //UPDATE 
        public void Alterar_Dados() 
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE empresa SET razao = @razao, fantasia=@fantasia, nome=@NOME, cnpj=@cnpj, rua=@rua, bairro=@bairro, cidade=@cidade, numero=@numero, cep=@cep, telefone=@telefone, celular=@celular  WHERE id=@id ";
                
                cmd.Parameters.Add("@razao", MySqlDbType.VarChar).Value = razao;
                cmd.Parameters.Add("@fantasia", MySqlDbType.VarChar).Value = fantasia;
                cmd.Parameters.Add("@cnpj", MySqlDbType.VarChar).Value = cnpj;
                cmd.Parameters.Add("@rua", MySqlDbType.VarChar).Value = rua;
                cmd.Parameters.Add("@bairro", MySqlDbType.VarChar).Value = bairro;
                cmd.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = cidade;
                cmd.Parameters.Add("@numero", MySqlDbType.VarChar).Value = numero;
                cmd.Parameters.Add("@cep", MySqlDbType.VarChar).Value = cep;
                cmd.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = telefone;
                cmd.Parameters.Add("@celular", MySqlDbType.VarChar).Value = celular;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //DELETE
        public void Deletar_Dados(string id) 
        {
            con.Open();
            string query = "DELETE FROM empresa WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            cmd.ExecuteNonQuery();
            con.Close();
            
        }

        //Listar DTV
        public void Listar_Dados(DataGridView dgv)
        {
            con.Open();
            string query = "SELECT * FROM empresa";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(dt);
            dgv.DataSource = dt;
            con.Close();
        }
    }
}
