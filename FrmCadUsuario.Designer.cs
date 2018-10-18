namespace SIG
{
    partial class FrmCadUsuario
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
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtRepeteSenha = new System.Windows.Forms.TextBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CboTipoUsuario = new System.Windows.Forms.ComboBox();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.TxtIdUsuario = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.DataCad = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.CboCadPor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.Location = new System.Drawing.Point(70, 287);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(78, 23);
            this.BtnCadastrar.TabIndex = 6;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(440, 287);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(54, 23);
            this.BtnSair.TabIndex = 10;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Senha:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(179, 121);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(305, 21);
            this.TxtUsuario.TabIndex = 2;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.Location = new System.Drawing.Point(179, 147);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(170, 21);
            this.TxtSenha.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Repetir Senha:";
            // 
            // TxtRepeteSenha
            // 
            this.TxtRepeteSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRepeteSenha.Location = new System.Drawing.Point(179, 173);
            this.TxtRepeteSenha.Name = "TxtRepeteSenha";
            this.TxtRepeteSenha.PasswordChar = '*';
            this.TxtRepeteSenha.Size = new System.Drawing.Size(170, 21);
            this.TxtRepeteSenha.TabIndex = 4;
            this.TxtRepeteSenha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RepeteSenha_KeyUp);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.Location = new System.Drawing.Point(218, 287);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(68, 23);
            this.BtnConsultar.TabIndex = 7;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(128, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "E-mail:";
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(179, 69);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(305, 21);
            this.TxtNome.TabIndex = 0;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(179, 95);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(305, 21);
            this.TxtEmail.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(137, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tipo:";
            // 
            // CboTipoUsuario
            // 
            this.CboTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipoUsuario.FormattingEnabled = true;
            this.CboTipoUsuario.Items.AddRange(new object[] {
            "Usuário",
            "Admin"});
            this.CboTipoUsuario.Location = new System.Drawing.Point(179, 198);
            this.CboTipoUsuario.Name = "CboTipoUsuario";
            this.CboTipoUsuario.Size = new System.Drawing.Size(170, 21);
            this.CboTipoUsuario.TabIndex = 5;
            this.CboTipoUsuario.Text = "Selecione";
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.Enabled = false;
            this.BtnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeletar.Location = new System.Drawing.Point(373, 287);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(61, 23);
            this.BtnDeletar.TabIndex = 9;
            this.BtnDeletar.Text = "Deletar";
            this.BtnDeletar.UseVisualStyleBackColor = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Enabled = false;
            this.BtnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterar.Location = new System.Drawing.Point(292, 287);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 8;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // TxtIdUsuario
            // 
            this.TxtIdUsuario.Enabled = false;
            this.TxtIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdUsuario.Location = new System.Drawing.Point(179, 43);
            this.TxtIdUsuario.MaxLength = 5;
            this.TxtIdUsuario.Name = "TxtIdUsuario";
            this.TxtIdUsuario.Size = new System.Drawing.Size(97, 21);
            this.TxtIdUsuario.TabIndex = 148;
            this.TxtIdUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtIdUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdUsuario_KeyPress_1);
            this.TxtIdUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtIdUsuario_KeyUp_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(123, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 149;
            this.label17.Text = "Código:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(154, 287);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(58, 23);
            this.BtnBuscar.TabIndex = 150;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // DataCad
            // 
            this.DataCad.CustomFormat = "dd/MM/yyyy";
            this.DataCad.Enabled = false;
            this.DataCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataCad.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataCad.Location = new System.Drawing.Point(179, 252);
            this.DataCad.Name = "DataCad";
            this.DataCad.Size = new System.Drawing.Size(170, 20);
            this.DataCad.TabIndex = 151;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(81, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 13);
            this.label14.TabIndex = 152;
            this.label14.Text = "Data Cadastro:";
            // 
            // CboCadPor
            // 
            this.CboCadPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCadPor.FormattingEnabled = true;
            this.CboCadPor.Items.AddRange(new object[] {
            "Usuário",
            "Admin"});
            this.CboCadPor.Location = new System.Drawing.Point(179, 225);
            this.CboCadPor.Name = "CboCadPor";
            this.CboCadPor.Size = new System.Drawing.Size(170, 21);
            this.CboCadPor.TabIndex = 153;
            this.CboCadPor.Text = "Selecione";
            this.CboCadPor.Click += new System.EventHandler(this.CboCadPor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 154;
            this.label8.Text = "Cadastrado Por:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.CboCadPor);
            this.groupBox1.Controls.Add(this.BtnCadastrar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.BtnSair);
            this.groupBox1.Controls.Add(this.DataCad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.TxtUsuario);
            this.groupBox1.Controls.Add(this.TxtIdUsuario);
            this.groupBox1.Controls.Add(this.TxtSenha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BtnAlterar);
            this.groupBox1.Controls.Add(this.TxtRepeteSenha);
            this.groupBox1.Controls.Add(this.BtnDeletar);
            this.groupBox1.Controls.Add(this.BtnConsultar);
            this.groupBox1.Controls.Add(this.CboTipoUsuario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 348);
            this.groupBox1.TabIndex = 155;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Usuário";
            // 
            // FrmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(617, 407);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmCadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIG - Cadastro de Usuário";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtRepeteSenha;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboTipoUsuario;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.TextBox TxtIdUsuario;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DateTimePicker DataCad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CboCadPor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}