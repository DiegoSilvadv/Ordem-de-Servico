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
using Agenda_OS_Diego.Database;

namespace Agenda_OS_Diego
{
    class CRUD : DataBase
    {
        DataBase DB = new DataBase();

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
            try
            {
                DB.AbrirConexao();
                string CommandText = "INSERT INTO empresa VALUES (0, @razao, @fantasia, @cnpj, @rua, @bairro, @cidade, @numero, @cep, @telefone, @celular, 0) ";
                MySqlCommand cmd = new MySqlCommand(CommandText, DB.con);

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
                DB.FecharConexao();

            }
            catch (Exception error) {
                MessageBox.Show(error.ToString());
            }
        }

        //UPDATE alterar dados
        public void Alterar_Dados()
        {
            try
            {
                DB.AbrirConexao();
                string query = "UPDATE empresa SET razao=@razao, fantasia=@fantasia, cnpj=@cnpj, rua=@rua, bairro=@bairro, cidade=@cidade, numero=@numero, cep=@cep, telefone=@telefone, celular=@celular WHERE id=@id ";
                MySqlCommand cmd = new MySqlCommand(query, DB.con);
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
                DB.FecharConexao();
            }
            catch (Exception error) {
                MessageBox.Show(error.ToString());
            }
                
            
        }

        //Listar datagridview
        public void Listar_Dados(DataGridView dgv)
        {
            try
            {
                DB.AbrirConexao();
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlSelectAll = "SELECT * FROM empresa";
                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, DB.con);
                DataTable table = new DataTable();
                MyDA.Fill(table);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;
                dgv.DataSource = bSource;
                DB.FecharConexao();

            } catch (Exception error){
                MessageBox.Show(error.ToString());
            }  
        }

        //pesquisa em tempo real no datagridview
        public void Listar_Dados_Especificos(DataGridView DGV, string razao)
        {
            try
            {
                DB.AbrirConexao();
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlSelectAll = "SELECT * FROM empresa WHERE razao LIKE '%" + razao.ToString() + "%'";
                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, DB.con);
                DataTable table = new DataTable();
                MyDA.Fill(table);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;
                DGV.DataSource = bSource;
                DB.FecharConexao();
            }
            catch (Exception error) {
                MessageBox.Show(error.ToString());
            }
        }


    }
}
