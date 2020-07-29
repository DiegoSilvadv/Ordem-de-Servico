using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Agenda_OS_Diego.Classes
{
    class BD
    {
        public MySqlConnection con;

        public BD() 
        {
            string host = "localhost";
            string db = "agenda";
            string port = "3308";
            string user = "root";
            string pass = "";
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
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand()) {
                cmd.CommandText = "INSERT INTO `empresa` VALUES (0, '@razao', '@fantasia', '@cnpj', '@rua', '@bairro', '@cidade', '@numero', '@cep', '@telefone', '@celular') ";

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

                cmd.ExecuteNonQuery();
                con.Close();
            }
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
        public void Deletar_Dados() 
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM empresa WHERE id=@id ";

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //Read function
        public void Listar_Dados()
        {
            dt.Clear();
            string query = "SELECT * FROM empresa";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];
        }
    }
}
