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

namespace Agenda_OS_Diego.Tecnico
{   
    class CrudTec : DataBase 
    {
        DataBase DB = new DataBase();

        public string id { set; get; }
        public string usuario { set; get; }
        public string senha { set; get; }
        public string nome { set; get; }
        public string rua { set; get; }
        public string bairro { set; get; }
        public string cidade { set; get; }
        public string numero { set; get; }
        public string cep { set; get; }
        public string uf { set; get; }
        public string complemento { set; get; }
        public string celular { set; get; }
        public string cnh { set; get; }
        public DateTime data_nascimento { set; get; }
        public bool inativar { set; get; }

        //criar dados dos tecnicos
        public void CriarDados() {

            try
            {
                DB.AbrirConexao();
                string CommandText = "INSERT INTO tecnico VALUES (0, @usuario, @senha, @nome_tecnico, @cnh, @cidade, @bairro, @rua, @numero, @cep, @uf, @complemento, @celular, @data_nascimento, @inativar)";
                MySqlCommand cmd = new MySqlCommand(CommandText, DB.con);

                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@nome_tecnico", nome);
                cmd.Parameters.AddWithValue("@cnh", cnh);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@bairro", bairro);
                cmd.Parameters.AddWithValue("@rua", rua);
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.Parameters.AddWithValue("@cep", cep);
                cmd.Parameters.AddWithValue("@uf", uf);
                cmd.Parameters.AddWithValue("@complemento", complemento);
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@data_nascimento", data_nascimento);
                cmd.Parameters.AddWithValue("@inativar", inativar);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                MessageBox.Show("Cadastrado com sucesso");
                DB.FecharConexao();
            }
            catch (Exception error) {
                MessageBox.Show(error.ToString());
            }
        }
        //listar ténicos
        public void ListarTecnico(DataGridView dgv) {
            try
            {
                DB.AbrirConexao();
                DataTable table = new DataTable();
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlSelectAll = "SELECT * FROM tecnico WHERE inativado = 0";
                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, DB.con);
                MyDA.Fill(table);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;
                dgv.DataSource = bSource;
                DB.FecharConexao();
            }
            catch (Exception error) { 
                MessageBox.Show(error.ToString());
            }

        }
        //update
        public void Alterar_Dados()
        {
            try
            {
                DB.AbrirConexao();
                string query = "UPDATE tecnico SET usuario=@usuario, senha=@senha, nome_tecnico=@nome, rua=@rua, bairro=@bairro, cidade=@cidade, numero=@numero, cep=@cep, complemento=@complemento, cep=@cep, celular=@celular, cnh=@cnh, data_nascimento=@data_nascimento, inativado=@inativado WHERE id_tecnico=@id ";
                MySqlCommand cmd = new MySqlCommand(query, DB.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@rua", rua);
                cmd.Parameters.AddWithValue("@bairro", bairro);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.Parameters.AddWithValue("@cep", cep);
                cmd.Parameters.AddWithValue("@uf", uf);
                cmd.Parameters.AddWithValue("@complemento", complemento);
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@cnh", cnh);
                cmd.Parameters.AddWithValue("@data_nascimento", data_nascimento);
                cmd.Parameters.AddWithValue("@inativado", inativar);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Alterado com sucesso");

                cmd.Parameters.Clear();
                DB.FecharConexao();
            }
            catch (Exception error) {
                MessageBox.Show(error.ToString());
            }
        }
       
        //pesquisa em tempo real no datagridview
        public void Listar_Dados_Especificos(DataGridView DGV)
        {
            try
            {
                DB.AbrirConexao();
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlSelectAll = "SELECT * FROM tecnico WHERE inativado = 0 and nome_tecnico LIKE '%" + nome.ToString() + "%'";
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

        public void Listar_Dados_EspecificosInativados(DataGridView DGV)
        {
            try
            {
                DB.AbrirConexao();
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlSelectAll = "SELECT * FROM tecnico WHERE inativado = 1 and nome_tecnico LIKE '%" + nome.ToString() + "%'";
                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, DB.con);
                DataTable table = new DataTable();
                MyDA.Fill(table);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;
                DGV.DataSource = bSource;
                DB.FecharConexao();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        public void ListarInativados(DataGridView DGV)
        {
            try
            {
                DB.AbrirConexao();
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlSelectAll = "SELECT * FROM tecnico WHERE inativado = 1";
                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, DB.con);
                DataTable table = new DataTable();
                MyDA.Fill(table);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;
                DGV.DataSource = bSource;
                DB.FecharConexao();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }


}
