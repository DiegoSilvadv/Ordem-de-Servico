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
using Agenda_OS_Diego.Tecnico;
using Agenda_OS_Diego.Database;

namespace Agenda_OS_Diego
{
   
    class CrudOs : DataBase
        {
            DataBase DB = new DataBase();

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
            public bool inativado { set; get; }



        //Listagem de Ordem de Serviço
        public void Listar_Dados(DataGridView dgv)
        {
            try
            {
                DB.AbrirConexao();
                string query = "select os.fk_empresa, os.inativado, os.fk_tecnico, e.celular, e.telefone, os.id_os, t.nome_tecnico, e.fantasia, e.cnpj, os.solicitante, os.assunto, os.descricao, os.atendimento, os.sistema, os.solucao, os.abertura, os.conclusao, os.status_os from tecnico as t inner join empresa as e inner join ordemservico as os where os.fk_empresa = e.id_empresa and os.fk_tecnico = t.id_tecnico and os.id_os = os.id_os and os.inativado = 0  ";
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                MyDA.SelectCommand = new MySqlCommand(query, DB.con);

                DataTable table = new DataTable();
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

        public void ListarOSInativada(DataGridView dgv)
        {
            try
            {
                DB.AbrirConexao();
                string query = "select os.fk_empresa, os.inativado, os.fk_tecnico, e.celular, e.telefone, os.id_os, t.nome_tecnico, e.fantasia, e.cnpj, os.solicitante, os.assunto, os.descricao, os.atendimento, os.sistema, os.solucao, os.abertura, os.conclusao, os.status_os from tecnico as t inner join empresa as e inner join ordemservico as os where os.fk_empresa = e.id_empresa and os.fk_tecnico = t.id_tecnico and os.id_os = os.id_os and os.inativado = 1  ";
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                MyDA.SelectCommand = new MySqlCommand(query, DB.con);

                DataTable table = new DataTable();
                MyDA.Fill(table);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;
                dgv.DataSource = bSource;
                DB.FecharConexao();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        //Filtro para listar Ordem de Serviço pendente
        public void ListarOSPendente(DataGridView dgv)
        {
            try
            {
                DB.AbrirConexao();
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlSelectAll = "SELECT os.fk_empresa, os.inativado, os.fk_tecnico, e.celular, e.telefone, os.id_os, t.nome_tecnico, e.fantasia, e.cnpj, os.solicitante, os.assunto, os.descricao, os.atendimento, os.sistema, os.solucao, os.abertura, os.conclusao, os.status_os from tecnico as t inner join empresa as e inner join ordemservico as os where os.fk_empresa = e.id_empresa and os.fk_tecnico = t.id_tecnico and os.id_os = os.id_os and os.inativado = 0 and status_os = 'Pendente'";
                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, DB.con);
                DataTable table = new DataTable();
                MyDA.Fill(table);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;
                dgv.DataSource = bSource;
                DB.FecharConexao();

            } catch (Exception error) {
                MessageBox.Show(error.ToString());
            }
        }

        // função para preencher os campos automaticamente
        public void ListarEmpresa() {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id_empresa, fantasia, cnpj, telefone, celular FROM empresa WHERE cnpj like @cnpj or fantasia like @fantasia", DB.con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@fantasia", fantasia);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);

                DB.AbrirConexao();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    this.id_empresa = Convert.ToInt32(dr["id_empresa"].ToString());
                    this.fantasia = dr["fantasia"].ToString();
                    this.cnpj = dr["cnpj"].ToString();
                    this.telefone = dr["telefone"].ToString();
                    this.celular = dr["celular"].ToString();
                }
                DB.FecharConexao();
            }
            catch (Exception error) {
                MessageBox.Show(error.ToString());
            }
        }
        
        //Cadastrar Ordem de Serviço
        public void CadastrarOS() {
            try
            {
                DB.AbrirConexao();

                string query = "INSERT INTO ordemservico VALUES( 0, @id_empresa, @id_tecnico, @solicitante, @assunto, @descricao, @atendimento, @sistema, @solucao, @abertura, @conclusao, @status, @inativado)";
                MySqlCommand cmd = new MySqlCommand(query, DB.con);

                cmd.Parameters.AddWithValue("@id_empresa", id_empresa);
                cmd.Parameters.AddWithValue("@id_tecnico", id_tecnico);
                cmd.Parameters.AddWithValue("@solicitante", solicitante);
                cmd.Parameters.AddWithValue("@assunto", assunto);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                cmd.Parameters.AddWithValue("@atendimento", atendimento);
                cmd.Parameters.AddWithValue("@sistema", sistema);
                cmd.Parameters.AddWithValue("@solucao", solucao);
                cmd.Parameters.AddWithValue("@abertura", abertura);
                cmd.Parameters.AddWithValue("@conclusao", conclusao);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@inativado", inativado);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastrado com sucesso!");
                cmd.Parameters.Clear();
                DB.FecharConexao();
            }
            catch (Exception error) {
                MessageBox.Show(error.ToString());
            }
        }
        
        //listagem dos técnicos
        public void ListarTecnico() {

            try
            {
                DB.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand("SELECT id_tecnico, nome_tecnico FROM tecnico ORDER BY nome_tecnico", DB.con);
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                this.tecnico = dt;
                DB.FecharConexao();
            }
            catch (Exception error) {
                MessageBox.Show(error.ToString());
            }

        }
        
        //alterar dados
        public void AlterarDados() {
            try
            {
                DB.AbrirConexao();
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
                    ",inativado = @inativado " +
                    "where id_os = @id_os";

                MySqlCommand cmd = new MySqlCommand(query, DB.con);

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
                cmd.Parameters.AddWithValue("@inativado", inativado);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Alterado com sucesso");

                cmd.Parameters.Clear();
                DB.FecharConexao();
            }
            catch (Exception error) { 
                MessageBox.Show(error.ToString());
            }

        }

        }
}

