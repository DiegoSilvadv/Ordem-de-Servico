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
            string port = "3306";
            string user = "root";
            string pass = "";
            string constring = "datasource =" + host + "; database=" + db + "; port=" + port + "; username=" + user + "; password=" + pass + "; SslMode=none";
            con = new MySqlConnection(constring);
        }
    }

    class CRUD : BD 
    {
        public string ID { set; get; }
        public string CNPJ { set; get;}
        public string RAZAO { set; get;}
        public string NOME { set; get;}
        public string ENDERECO { set; get;}
        public string CEP { set; get;}
        public string TELEFONE { set; get;}
        public string CELULAR { set; get;}



        //Read Properties
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();


        //CREATE
        public void Criar_Dados() 
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand()) {
                cmd.CommandText = "INSERT INTO `empresa` (`cnpj`, `razao`, `nome`, `endereco`, `cep`, `telefone`, `celular`) VALUES (NULL, '@CNPJ', '@RAZAO', '@NOME', '@ENDERECO', '@CEP', '@TELEFONE', '@CELULAR') ";

                cmd.Parameters.Add("@CNPJ", MySqlDbType.VarChar).Value = CNPJ;
                cmd.Parameters.Add("@RAZAO", MySqlDbType.VarChar).Value = RAZAO;
                cmd.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = NOME;
                cmd.Parameters.Add("@ENDERECO", MySqlDbType.VarChar).Value = ENDERECO;
                cmd.Parameters.Add("@CEP", MySqlDbType.VarChar).Value = CEP;
                cmd.Parameters.Add("@TELEFONE", MySqlDbType.VarChar).Value = TELEFONE;
                cmd.Parameters.Add("@CELULAR", MySqlDbType.VarChar).Value = CELULAR;

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
                cmd.CommandText = "UPDATE empresa SET cnpj = @CNPJ, razao=@RAZAO, nome=@NOME, endereco=@ENDERECO, cep=@CEP, telefone=@TELEFONE, celular=@CELULAR WHERE id=@ID ";

                cmd.Parameters.Add("@CNPJ", MySqlDbType.VarChar).Value = CNPJ;
                cmd.Parameters.Add("@RAZAO", MySqlDbType.VarChar).Value = RAZAO;
                cmd.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = NOME;
                cmd.Parameters.Add("@ENDERECO", MySqlDbType.VarChar).Value = ENDERECO;
                cmd.Parameters.Add("@CEP", MySqlDbType.VarChar).Value = CEP;
                cmd.Parameters.Add("@TELEFONE", MySqlDbType.VarChar).Value = TELEFONE;
                cmd.Parameters.Add("@CELULAR", MySqlDbType.VarChar).Value = CELULAR;


                cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = ID;

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
                cmd.CommandText = "DELETE FROM empresa WHERE id=@ID ";

                cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = ID;

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
