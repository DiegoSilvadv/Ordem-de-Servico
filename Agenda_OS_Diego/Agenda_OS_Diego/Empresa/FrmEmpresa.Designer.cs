namespace Agenda_OS_Diego
{
    partial class FrmEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpresa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_email_empresa = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_email_escritorio = new System.Windows.Forms.TextBox();
            this.cb_inativar = new System.Windows.Forms.CheckBox();
            this.mtb_IE = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fantasia = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.mtb_celular = new System.Windows.Forms.MaskedTextBox();
            this.mtb_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_razao = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mtb_cep = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_cadastrar_empresa = new System.Windows.Forms.Button();
            this.btn_nova_empresa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 35);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(724, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(364, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Empresa";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 483);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(766, 35);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_email_empresa);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txt_email_escritorio);
            this.groupBox1.Controls.Add(this.cb_inativar);
            this.groupBox1.Controls.Add(this.mtb_IE);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_fantasia);
            this.groupBox1.Controls.Add(this.lbl_id);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.mtb_celular);
            this.groupBox1.Controls.Add(this.mtb_cnpj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mtb_telefone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_razao);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 231);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações gerais";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(47, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 78;
            this.label15.Text = "E-mail empresa:";
            // 
            // txt_email_empresa
            // 
            this.txt_email_empresa.BackColor = System.Drawing.SystemColors.Control;
            this.txt_email_empresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email_empresa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_email_empresa.Location = new System.Drawing.Point(50, 203);
            this.txt_email_empresa.Name = "txt_email_empresa";
            this.txt_email_empresa.Size = new System.Drawing.Size(381, 21);
            this.txt_email_empresa.TabIndex = 77;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(47, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 13);
            this.label14.TabIndex = 76;
            this.label14.Text = "E-mail escritório:";
            // 
            // txt_email_escritorio
            // 
            this.txt_email_escritorio.BackColor = System.Drawing.SystemColors.Control;
            this.txt_email_escritorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email_escritorio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_email_escritorio.Location = new System.Drawing.Point(50, 165);
            this.txt_email_escritorio.Name = "txt_email_escritorio";
            this.txt_email_escritorio.Size = new System.Drawing.Size(381, 21);
            this.txt_email_escritorio.TabIndex = 75;
            // 
            // cb_inativar
            // 
            this.cb_inativar.AutoSize = true;
            this.cb_inativar.Location = new System.Drawing.Point(598, 26);
            this.cb_inativar.Name = "cb_inativar";
            this.cb_inativar.Size = new System.Drawing.Size(63, 17);
            this.cb_inativar.TabIndex = 74;
            this.cb_inativar.Text = "Inativar";
            this.cb_inativar.UseVisualStyleBackColor = true;
            // 
            // mtb_IE
            // 
            this.mtb_IE.BackColor = System.Drawing.SystemColors.Control;
            this.mtb_IE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtb_IE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mtb_IE.Location = new System.Drawing.Point(148, 124);
            this.mtb_IE.Name = "mtb_IE";
            this.mtb_IE.Size = new System.Drawing.Size(113, 21);
            this.mtb_IE.TabIndex = 73;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(145, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 13);
            this.label12.TabIndex = 72;
            this.label12.Text = "RG/Incrição estadual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(47, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Nome:";
            // 
            // txt_fantasia
            // 
            this.txt_fantasia.BackColor = System.Drawing.SystemColors.Control;
            this.txt_fantasia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_fantasia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_fantasia.Location = new System.Drawing.Point(50, 39);
            this.txt_fantasia.Name = "txt_fantasia";
            this.txt_fantasia.Size = new System.Drawing.Size(381, 21);
            this.txt_fantasia.TabIndex = 70;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_id.Location = new System.Drawing.Point(546, 30);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(13, 13);
            this.lbl_id.TabIndex = 69;
            this.lbl_id.Text = "0";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ID.Location = new System.Drawing.Point(519, 30);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 13);
            this.ID.TabIndex = 68;
            this.ID.Text = "ID:";
            // 
            // mtb_celular
            // 
            this.mtb_celular.BackColor = System.Drawing.SystemColors.Control;
            this.mtb_celular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtb_celular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mtb_celular.Location = new System.Drawing.Point(352, 124);
            this.mtb_celular.Mask = "(99) 9 9999-9999";
            this.mtb_celular.Name = "mtb_celular";
            this.mtb_celular.Size = new System.Drawing.Size(79, 21);
            this.mtb_celular.TabIndex = 61;
            // 
            // mtb_cnpj
            // 
            this.mtb_cnpj.BackColor = System.Drawing.SystemColors.Control;
            this.mtb_cnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtb_cnpj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mtb_cnpj.Location = new System.Drawing.Point(50, 124);
            this.mtb_cnpj.Mask = "99.999.999/9999-99";
            this.mtb_cnpj.Name = "mtb_cnpj";
            this.mtb_cnpj.Size = new System.Drawing.Size(92, 21);
            this.mtb_cnpj.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(47, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "CNPJ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(349, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Celular:";
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.BackColor = System.Drawing.SystemColors.Control;
            this.mtb_telefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtb_telefone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mtb_telefone.Location = new System.Drawing.Point(272, 124);
            this.mtb_telefone.Mask = "(99) 9999-9999";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(74, 21);
            this.mtb_telefone.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(269, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Telefone:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(47, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Razão Social:";
            // 
            // txt_razao
            // 
            this.txt_razao.BackColor = System.Drawing.SystemColors.Control;
            this.txt_razao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_razao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_razao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_razao.Location = new System.Drawing.Point(50, 80);
            this.txt_razao.Name = "txt_razao";
            this.txt_razao.Size = new System.Drawing.Size(381, 21);
            this.txt_razao.TabIndex = 47;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.cb_estado);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.mtb_cep);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_numero);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_rua);
            this.groupBox2.Controls.Add(this.txt_cidade);
            this.groupBox2.Controls.Add(this.txt_bairro);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(40, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 129);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // cb_estado
            // 
            this.cb_estado.BackColor = System.Drawing.SystemColors.Control;
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cb_estado.Location = new System.Drawing.Point(50, 83);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(85, 21);
            this.cb_estado.TabIndex = 81;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(47, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 80;
            this.label13.Text = "Estado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(296, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "Numero:";
            // 
            // mtb_cep
            // 
            this.mtb_cep.BackColor = System.Drawing.SystemColors.Control;
            this.mtb_cep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtb_cep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mtb_cep.Location = new System.Drawing.Point(416, 84);
            this.mtb_cep.Mask = "99.999.999";
            this.mtb_cep.Name = "mtb_cep";
            this.mtb_cep.Size = new System.Drawing.Size(80, 21);
            this.mtb_cep.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(413, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "CEP:";
            // 
            // txt_numero
            // 
            this.txt_numero.BackColor = System.Drawing.SystemColors.Control;
            this.txt_numero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_numero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_numero.Location = new System.Drawing.Point(299, 84);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(111, 21);
            this.txt_numero.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(47, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Rua:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(147, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 76;
            this.label9.Text = "Bairro:";
            // 
            // txt_rua
            // 
            this.txt_rua.BackColor = System.Drawing.SystemColors.Control;
            this.txt_rua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_rua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_rua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_rua.Location = new System.Drawing.Point(50, 42);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(381, 21);
            this.txt_rua.TabIndex = 69;
            // 
            // txt_cidade
            // 
            this.txt_cidade.BackColor = System.Drawing.SystemColors.Control;
            this.txt_cidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cidade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_cidade.Location = new System.Drawing.Point(439, 42);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(148, 21);
            this.txt_cidade.TabIndex = 73;
            // 
            // txt_bairro
            // 
            this.txt_bairro.BackColor = System.Drawing.SystemColors.Control;
            this.txt_bairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_bairro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_bairro.Location = new System.Drawing.Point(150, 84);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(143, 21);
            this.txt_bairro.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(436, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = "Cidade:";
            // 
            // btn_cadastrar_empresa
            // 
            this.btn_cadastrar_empresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.btn_cadastrar_empresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar_empresa.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar_empresa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cadastrar_empresa.Location = new System.Drawing.Point(600, 443);
            this.btn_cadastrar_empresa.Name = "btn_cadastrar_empresa";
            this.btn_cadastrar_empresa.Size = new System.Drawing.Size(128, 34);
            this.btn_cadastrar_empresa.TabIndex = 68;
            this.btn_cadastrar_empresa.Text = "Cadastrar";
            this.btn_cadastrar_empresa.UseVisualStyleBackColor = false;
            this.btn_cadastrar_empresa.Click += new System.EventHandler(this.btn_cadastrar_empresa_Click);
            // 
            // btn_nova_empresa
            // 
            this.btn_nova_empresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.btn_nova_empresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nova_empresa.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nova_empresa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_nova_empresa.Location = new System.Drawing.Point(466, 443);
            this.btn_nova_empresa.Name = "btn_nova_empresa";
            this.btn_nova_empresa.Size = new System.Drawing.Size(128, 34);
            this.btn_nova_empresa.TabIndex = 69;
            this.btn_nova_empresa.Text = "Novo";
            this.btn_nova_empresa.UseVisualStyleBackColor = false;
            this.btn_nova_empresa.Click += new System.EventHandler(this.btn_nova_empresa_Click);
            // 
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 518);
            this.Controls.Add(this.btn_nova_empresa);
            this.Controls.Add(this.btn_cadastrar_empresa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmpresa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEmpresa_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.MaskedTextBox mtb_celular;
        public System.Windows.Forms.MaskedTextBox mtb_cnpj;
        public System.Windows.Forms.MaskedTextBox mtb_telefone;
        public System.Windows.Forms.TextBox txt_razao;
        public System.Windows.Forms.MaskedTextBox mtb_IE;
        public System.Windows.Forms.TextBox txt_fantasia;
        public System.Windows.Forms.Label lbl_id;
        public System.Windows.Forms.ComboBox cb_estado;
        public System.Windows.Forms.MaskedTextBox mtb_cep;
        public System.Windows.Forms.TextBox txt_numero;
        public System.Windows.Forms.TextBox txt_rua;
        public System.Windows.Forms.TextBox txt_cidade;
        public System.Windows.Forms.TextBox txt_bairro;
        public System.Windows.Forms.Button btn_cadastrar_empresa;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button btn_nova_empresa;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txt_email_escritorio;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txt_email_empresa;
        public System.Windows.Forms.CheckBox cb_inativar;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}