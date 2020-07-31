namespace Agenda_OS_Diego
{
    partial class Empresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empresa));
            this.dgv_empresa = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cadastrar_empresa = new System.Windows.Forms.Button();
            this.gb_empresa = new System.Windows.Forms.GroupBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.mtb_celular = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtb_cep = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fantasia = new System.Windows.Forms.TextBox();
            this.mtb_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_razao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empresa)).BeginInit();
            this.gb_empresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_empresa
            // 
            this.dgv_empresa.AllowUserToAddRows = false;
            this.dgv_empresa.AllowUserToDeleteRows = false;
            this.dgv_empresa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.dgv_empresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_empresa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_empresa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_empresa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_empresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empresa.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_empresa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_empresa.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgv_empresa.Location = new System.Drawing.Point(0, 150);
            this.dgv_empresa.Name = "dgv_empresa";
            this.dgv_empresa.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_empresa.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_empresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_empresa.Size = new System.Drawing.Size(813, 440);
            this.dgv_empresa.TabIndex = 2;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.Location = new System.Drawing.Point(8, 83);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(56, 61);
            this.btn_editar.TabIndex = 3;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.DarkRed;
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.Location = new System.Drawing.Point(70, 83);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(56, 61);
            this.btn_excluir.TabIndex = 4;
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(83, 40);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(398, 20);
            this.txt_pesquisa.TabIndex = 6;
            this.txt_pesquisa.TextChanged += new System.EventHandler(this.txt_pesquisa_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 636);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 25);
            this.panel1.TabIndex = 7;
            // 
            // btn_cadastrar_empresa
            // 
            this.btn_cadastrar_empresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.btn_cadastrar_empresa.FlatAppearance.BorderSize = 0;
            this.btn_cadastrar_empresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar_empresa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cadastrar_empresa.Location = new System.Drawing.Point(983, 556);
            this.btn_cadastrar_empresa.Name = "btn_cadastrar_empresa";
            this.btn_cadastrar_empresa.Size = new System.Drawing.Size(128, 34);
            this.btn_cadastrar_empresa.TabIndex = 9;
            this.btn_cadastrar_empresa.Text = "Cadastrar";
            this.btn_cadastrar_empresa.UseVisualStyleBackColor = false;
            this.btn_cadastrar_empresa.Click += new System.EventHandler(this.btn_cadastrar_empresa_Click);
            // 
            // gb_empresa
            // 
            this.gb_empresa.Controls.Add(this.lbl_id);
            this.gb_empresa.Controls.Add(this.ID);
            this.gb_empresa.Controls.Add(this.label10);
            this.gb_empresa.Controls.Add(this.txt_numero);
            this.gb_empresa.Controls.Add(this.label9);
            this.gb_empresa.Controls.Add(this.txt_bairro);
            this.gb_empresa.Controls.Add(this.label8);
            this.gb_empresa.Controls.Add(this.txt_cidade);
            this.gb_empresa.Controls.Add(this.mtb_celular);
            this.gb_empresa.Controls.Add(this.label7);
            this.gb_empresa.Controls.Add(this.mtb_telefone);
            this.gb_empresa.Controls.Add(this.label6);
            this.gb_empresa.Controls.Add(this.mtb_cep);
            this.gb_empresa.Controls.Add(this.label5);
            this.gb_empresa.Controls.Add(this.label4);
            this.gb_empresa.Controls.Add(this.txt_rua);
            this.gb_empresa.Controls.Add(this.label3);
            this.gb_empresa.Controls.Add(this.txt_fantasia);
            this.gb_empresa.Controls.Add(this.mtb_cnpj);
            this.gb_empresa.Controls.Add(this.label2);
            this.gb_empresa.Controls.Add(this.label1);
            this.gb_empresa.Controls.Add(this.txt_razao);
            this.gb_empresa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_empresa.Location = new System.Drawing.Point(819, 150);
            this.gb_empresa.Name = "gb_empresa";
            this.gb_empresa.Size = new System.Drawing.Size(432, 400);
            this.gb_empresa.TabIndex = 8;
            this.gb_empresa.TabStop = false;
            this.gb_empresa.Text = "Empresas";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(355, 32);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(13, 13);
            this.lbl_id.TabIndex = 25;
            this.lbl_id.Text = "0";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(328, 32);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(21, 13);
            this.ID.TabIndex = 24;
            this.ID.Text = "ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Numero:";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(295, 307);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(111, 20);
            this.txt_numero.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Bairro:";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(25, 307);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(110, 20);
            this.txt_bairro.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cidade:";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(141, 307);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(148, 20);
            this.txt_cidade.TabIndex = 18;
            // 
            // mtb_celular
            // 
            this.mtb_celular.Location = new System.Drawing.Point(296, 369);
            this.mtb_celular.Mask = "(99) 9 9999-9999";
            this.mtb_celular.Name = "mtb_celular";
            this.mtb_celular.Size = new System.Drawing.Size(110, 20);
            this.mtb_celular.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(293, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Celular:";
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(141, 369);
            this.mtb_telefone.Mask = "(99) 9999-9999";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(110, 20);
            this.mtb_telefone.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(138, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Telefone:";
            // 
            // mtb_cep
            // 
            this.mtb_cep.Location = new System.Drawing.Point(25, 369);
            this.mtb_cep.Mask = "99.999.999";
            this.mtb_cep.Name = "mtb_cep";
            this.mtb_cep.Size = new System.Drawing.Size(80, 20);
            this.mtb_cep.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(22, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "CEP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rua:";
            // 
            // txt_rua
            // 
            this.txt_rua.Location = new System.Drawing.Point(25, 236);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(381, 20);
            this.txt_rua.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome/Fantasia:";
            // 
            // txt_fantasia
            // 
            this.txt_fantasia.Location = new System.Drawing.Point(28, 127);
            this.txt_fantasia.Name = "txt_fantasia";
            this.txt_fantasia.Size = new System.Drawing.Size(381, 20);
            this.txt_fantasia.TabIndex = 8;
            // 
            // mtb_cnpj
            // 
            this.mtb_cnpj.Location = new System.Drawing.Point(28, 186);
            this.mtb_cnpj.Mask = "99.999.999/9999-99";
            this.mtb_cnpj.Name = "mtb_cnpj";
            this.mtb_cnpj.Size = new System.Drawing.Size(110, 20);
            this.mtb_cnpj.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CNPJ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Razão:";
            // 
            // txt_razao
            // 
            this.txt_razao.Location = new System.Drawing.Point(28, 65);
            this.txt_razao.Name = "txt_razao";
            this.txt_razao.Size = new System.Drawing.Size(381, 20);
            this.txt_razao.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(80, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Pesquise pela razão social...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1264, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_cadastrar_empresa);
            this.Controls.Add(this.gb_empresa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_pesquisa);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.dgv_empresa);
            this.Name = "Empresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.Empresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empresa)).EndInit();
            this.gb_empresa.ResumeLayout(false);
            this.gb_empresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_empresa;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cadastrar_empresa;
        private System.Windows.Forms.GroupBox gb_empresa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.MaskedTextBox mtb_celular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtb_cep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fantasia;
        private System.Windows.Forms.MaskedTextBox mtb_cnpj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_razao;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}