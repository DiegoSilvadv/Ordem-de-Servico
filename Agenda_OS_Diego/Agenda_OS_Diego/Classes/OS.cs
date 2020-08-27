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
            public int id_ordemServico { set; get; }
            public int id_empresa { set; get; }
            public int id_tecnico { set; get; }
            public DataTable tecnico { set; get; }
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
            public DateTime abertura { set; get; }
            public DateTime conclusao { set; get; }
            public string status { set; get; }

        public void Listar_Dados(DataGridView dgv)
        {
            con.Open();

            string query = "select os.fk_empresa, os.fk_tecnico, e.celular, e.telefone, os.id_os, t.nome_tecnico, e.fantasia, e.cnpj, os.solicitante, os.info_extra, os.assunto, os.descricao, os.atendimento, os.sistema, os.solucao, os.abertura, os.conclusao, os.status_os from tecnico as t inner join empresa as e inner join ordemservico as os where os.fk_empresa = e.id_empresa and os.fk_tecnico = t.id_tecnico and os.id_os = os.id_os";
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            MyDA.SelectCommand = new MySqlCommand(query, con);
            
            DataTable table = new DataTable();
            MyDA.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv.DataSource = bSource;

            con.Close();
        }

        public void ListarOSPendente(DataGridView dgv)
        {
            con.Open();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT * FROM ordemservico WHERE status_os = 'Pendente'";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, con);
            DataTable table = new DataTable();
            MyDA.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv.DataSource = bSource;

            con.Close();
        }

        // função para preencher os campos automaticamente
        public void ListarEmpresa() {

            MySqlCommand cmd = new MySqlCommand("SELECT id_empresa, fantasia, cnpj, telefone, celular FROM empresa WHERE cnpj like @cnpj and fantasia like @fantasia", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@fantasia", fantasia);
            cmd.Parameters.AddWithValue("@cnpj", cnpj);

            con.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                MessageBox.Show("" + cnpj);
                this.id_empresa = Convert.ToInt32(dr["id_empresa"].ToString());
                this.fantasia = dr["fantasia"].ToString();
                this.cnpj = dr["cnpj"].ToString();
                this.telefone = dr["telefone"].ToString();
                this.celular = dr["celular"].ToString();
            }
            con.Close();

        }

        public void CadastrarOS() {
            string query = "INSERT INTO ordemservico VALUES( 0, @id_empresa, @id_tecnico, @solicitante, @info_extra, @assunto, @descricao, @atendimento, @sistema, @solucao, @abertura, @conclusao, @status, 0 )";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id_empresa", id_empresa);
            cmd.Parameters.AddWithValue("@id_tecnico", id_tecnico);
            cmd.Parameters.AddWithValue("@solicitante", solicitante);
            cmd.Parameters.AddWithValue("@info_extra", informação_extra);
            cmd.Parameters.AddWithValue("@assunto", assunto);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@atendimento", atendimento);
            cmd.Parameters.AddWithValue("@sistema", sistema);
            cmd.Parameters.AddWithValue("@solucao", solucao);
            cmd.Parameters.AddWithValue("@abertura", abertura);
            cmd.Parameters.AddWithValue("@conclusao", conclusao);
            cmd.Parameters.AddWithValue("@status", status);
            con.Open();
            MessageBox.Show("Cadastrado com sucesso!");
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void ListarTecnico() {
            
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT id_tecnico, nome_tecnico FROM tecnico ORDER BY nome_tecnico", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            this.tecnico = dt;
            con.Close();
        }

        public void AlterarDados() {
            con.Open();

            string query = "update ordemservico set fk_tecnico = @id_tecnico , fk_empresa = @id_empresa" +
                    ",solicitante = @solicitante" +
                    ",info_extra = @informacao_extra" +
                    ",assunto = @assunto" +
                    ",descricao = @descricao" +
                    ",atendimento = @atendimento" +
                    ",sistema = @sistema" +
                    ",solucao = @solucao" +
                    ",abertura = @abertura" +
                    ",conclusao = @conclusao" +
                    ",status_os = @status " +
                    "where id_os = @id_os";

            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id_os", id_ordemServico);
            cmd.Parameters.AddWithValue("@id_empresa", id_empresa);
            cmd.Parameters.AddWithValue("@id_tecnico", id_tecnico);
            cmd.Parameters.AddWithValue("@solicitante", solicitante);
            cmd.Parameters.AddWithValue("@informacao_extra", informação_extra);
            cmd.Parameters.AddWithValue("@assunto", assunto);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@atendimento", atendimento);
            cmd.Parameters.AddWithValue("@sistema", sistema);
            cmd.Parameters.AddWithValue("@solucao", solucao);
            cmd.Parameters.AddWithValue("@abertura", abertura);
            cmd.Parameters.AddWithValue("@conclusao", conclusao);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Alterado com sucesso");

            cmd.Parameters.Clear();
            con.Close();
        }

        }
}

