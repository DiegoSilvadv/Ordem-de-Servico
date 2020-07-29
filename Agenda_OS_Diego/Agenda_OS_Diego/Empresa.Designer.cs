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
            this.dgv_empresa = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empresa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_empresa
            // 
            this.dgv_empresa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.dgv_empresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_empresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empresa.Location = new System.Drawing.Point(1, 171);
            this.dgv_empresa.Name = "dgv_empresa";
            this.dgv_empresa.Size = new System.Drawing.Size(967, 334);
            this.dgv_empresa.TabIndex = 2;
            this.dgv_empresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_empresa_CellContentClick);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_editar.Location = new System.Drawing.Point(21, 77);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(56, 61);
            this.btn_editar.TabIndex = 3;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.DarkRed;
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_excluir.Location = new System.Drawing.Point(145, 77);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(56, 61);
            this.btn_excluir.TabIndex = 4;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_novo.FlatAppearance.BorderSize = 0;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_novo.Location = new System.Drawing.Point(83, 77);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(56, 61);
            this.btn_novo.TabIndex = 5;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 508);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.dgv_empresa);
            this.Name = "Empresa";
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.Empresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_empresa;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.TextBox textBox1;
    }
}