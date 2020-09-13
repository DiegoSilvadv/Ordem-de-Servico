﻿using System;
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
        public string inscricao_estadual { set; get; }
        public string rua { set; get; }
        public string bairro { set; get; }
        public string cidade { set; get; }
        public string numero { set; get; }
        public string cep { set; get; }
        public string uf { set; get; }
        public string telefone { set; get; }
        public string celular { set; get; }
        public string email_contador { set; get; }
        public string email { set; get; }
        public bool inativado { set; get; }


        //Read Properties
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        //CREATE dados
        public void Criar_Dados()
        {
            try
            {
                DB.AbrirConexao();
                string CommandText = "INSERT INTO empresa VALUES (0, @razao, @fantasia, @cnpj, @inscricao_estadual, @rua, @bairro, @cidade, @numero, @cep, @uf, @telefone, @celular, @email_contador, @email, @inativado) ";
                MySqlCommand cmd = new MySqlCommand(CommandText, DB.con);

                cmd.Parameters.AddWithValue("@razao", razao);
                cmd.Parameters.AddWithValue("@fantasia", fantasia);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);
                cmd.Parameters.AddWithValue("@inscricao_estadual", inscricao_estadual);
                cmd.Parameters.AddWithValue("@rua", rua);
                cmd.Parameters.AddWithValue("@bairro", bairro);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.Parameters.AddWithValue("@cep", cep);
                cmd.Parameters.AddWithValue("@uf", uf);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@email_contador", email_contador);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@inativado", inativado);
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
                string query = "UPDATE empresa SET razao=@razao, fantasia=@fantasia, cnpj=@cnpj, inscricao_estadual=@inscricao_estadual, rua=@rua, bairro=@bairro, cidade=@cidade, numero=@numero, cep=@cep, uf=@uf, telefone=@telefone, celular=@celular, email_contador=@email_contador, email=@email, inativado=@inativado WHERE id_empresa=@id ";
                MySqlCommand cmd = new MySqlCommand(query, DB.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@razao", razao);
                cmd.Parameters.AddWithValue("@fantasia", fantasia);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);
                cmd.Parameters.AddWithValue("@inscricao_estadual", inscricao_estadual);
                cmd.Parameters.AddWithValue("@rua", rua);
                cmd.Parameters.AddWithValue("@bairro", bairro);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.Parameters.AddWithValue("@cep", cep);
                cmd.Parameters.AddWithValue("@uf", uf);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@email_contador", email_contador);
                cmd.Parameters.AddWithValue("@email", email);
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

        //Listar datagridview
        public void Listar_Dados(DataGridView dgv)
        {
            try
            {
                DB.AbrirConexao();
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlSelectAll = "SELECT * FROM empresa WHERE inativado = 0";
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
                string sqlSelectAll = "SELECT * FROM empresa WHERE inativado = 0 and razao LIKE '%" + razao.ToString() + "%'";
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
                string sqlSelectAll = "SELECT * FROM empresa WHERE inativado = 1 and razao LIKE '%" + razao.ToString() + "%'";
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
                string sqlSelectAll = "SELECT * FROM empresa WHERE inativado = 1";
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
