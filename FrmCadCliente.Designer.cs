namespace SIG
{
    partial class FrmCadCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadCliente));
            this.MktCelular = new System.Windows.Forms.MaskedTextBox();
            this.MktCPF = new System.Windows.Forms.MaskedTextBox();
            this.MktCep = new System.Windows.Forms.MaskedTextBox();
            this.MkFoneComercial = new System.Windows.Forms.MaskedTextBox();
            this.MktFoneFixo = new System.Windows.Forms.MaskedTextBox();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.CboSexo = new System.Windows.Forms.ComboBox();
            this.dataNasc = new System.Windows.Forms.DateTimePicker();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtRG = new System.Windows.Forms.TextBox();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CboCadPor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodCliente = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.DataCad = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MktCelular
            // 
            this.MktCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MktCelular.Location = new System.Drawing.Point(452, 283);
            this.MktCelular.Mask = "(99) 00000-0000";
            this.MktCelular.Name = "MktCelular";
            this.MktCelular.Size = new System.Drawing.Size(148, 20);
            this.MktCelular.TabIndex = 9;
            // 
            // MktCPF
            // 
            this.MktCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MktCPF.Location = new System.Drawing.Point(262, 329);
            this.MktCPF.Mask = "000-000-000-00";
            this.MktCPF.Name = "MktCPF";
            this.MktCPF.Size = new System.Drawing.Size(147, 20);
            this.MktCPF.TabIndex = 11;
            // 
            // MktCep
            // 
            this.MktCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MktCep.Location = new System.Drawing.Point(452, 235);
            this.MktCep.Mask = "00000-999";
            this.MktCep.Name = "MktCep";
            this.MktCep.Size = new System.Drawing.Size(148, 20);
            this.MktCep.TabIndex = 6;
            // 
            // MkFoneComercial
            // 
            this.MkFoneComercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MkFoneComercial.Location = new System.Drawing.Point(243, 281);
            this.MkFoneComercial.Mask = "(99) 0000-0000";
            this.MkFoneComercial.Name = "MkFoneComercial";
            this.MkFoneComercial.Size = new System.Drawing.Size(166, 20);
            this.MkFoneComercial.TabIndex = 8;
            // 
            // MktFoneFixo
            // 
            this.MktFoneFixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MktFoneFixo.Location = new System.Drawing.Point(56, 281);
            this.MktFoneFixo.Mask = "(99) 0000-0000";
            this.MktFoneFixo.Name = "MktFoneFixo";
            this.MktFoneFixo.Size = new System.Drawing.Size(158, 20);
            this.MktFoneFixo.TabIndex = 7;
            // 
            // CmbEstado
            // 
            this.CmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "Acre - AC",
            "Alagoas - AL",
            "Amapá - AP",
            "Amazonas - AM",
            "Bahia  - BA",
            "Ceará - CE",
            "Distrito Federal  - DF",
            "Espírito Santo - ES",
            "Goiás - GO",
            "Maranhão - MA",
            "Mato Grosso - MT",
            "Mato Grosso do Sul - MS",
            "Minas Gerais - MG",
            "Pará - PA",
            "Paraíba - PB",
            "Paraná - PR",
            "Pernambuco - PE",
            "Piauí - PI",
            "Rio de Janeiro - RJ",
            "Rio Grande do Norte - RN",
            "Rio Grande do Sul - RS",
            "Rondônia - RO",
            "Roraima - RR",
            "Santa Catarina - SC",
            "São Paulo - SP",
            "Sergipe - SE",
            "Tocantins - TO"});
            this.CmbEstado.Location = new System.Drawing.Point(56, 234);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(369, 21);
            this.CmbEstado.TabIndex = 5;
            this.CmbEstado.Text = "Selecione";
            // 
            // CboSexo
            // 
            this.CboSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboSexo.FormattingEnabled = true;
            this.CboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.CboSexo.Location = new System.Drawing.Point(452, 140);
            this.CboSexo.Name = "CboSexo";
            this.CboSexo.Size = new System.Drawing.Size(148, 21);
            this.CboSexo.TabIndex = 2;
            this.CboSexo.Text = "Selecione";
            // 
            // dataNasc
            // 
            this.dataNasc.CustomFormat = "dd/MM/yyyy";
            this.dataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNasc.Location = new System.Drawing.Point(452, 327);
            this.dataNasc.Name = "dataNasc";
            this.dataNasc.Size = new System.Drawing.Size(148, 20);
            this.dataNasc.TabIndex = 12;
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.Enabled = false;
            this.BtnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeletar.Location = new System.Drawing.Point(422, 418);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(86, 27);
            this.BtnDeletar.TabIndex = 19;
            this.BtnDeletar.Text = "Deletar";
            this.BtnDeletar.UseVisualStyleBackColor = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click_1);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Enabled = false;
            this.BtnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterar.Location = new System.Drawing.Point(328, 418);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(86, 27);
            this.BtnAlterar.TabIndex = 18;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(53, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 15);
            this.label17.TabIndex = 110;
            this.label17.Text = "Código";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.Location = new System.Drawing.Point(234, 418);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(86, 27);
            this.BtnConsultar.TabIndex = 17;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(450, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 15);
            this.label16.TabIndex = 109;
            this.label16.Text = "Sexo";
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(515, 418);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(86, 27);
            this.BtnSair.TabIndex = 20;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(141, 418);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(86, 27);
            this.BtnBuscar.TabIndex = 16;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.Location = new System.Drawing.Point(56, 418);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(77, 27);
            this.BtnCadastrar.TabIndex = 15;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click_1);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(56, 374);
            this.TxtEmail.MaxLength = 100;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(349, 20);
            this.TxtEmail.TabIndex = 13;
            // 
            // TxtRG
            // 
            this.TxtRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRG.Location = new System.Drawing.Point(56, 329);
            this.TxtRG.MaxLength = 10;
            this.TxtRG.Name = "TxtRG";
            this.TxtRG.Size = new System.Drawing.Size(181, 20);
            this.TxtRG.TabIndex = 10;
            // 
            // TxtCidade
            // 
            this.TxtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCidade.Location = new System.Drawing.Point(56, 189);
            this.TxtCidade.MaxLength = 100;
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(366, 20);
            this.TxtCidade.TabIndex = 3;
            // 
            // TxtBairro
            // 
            this.TxtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBairro.Location = new System.Drawing.Point(452, 190);
            this.TxtBairro.MaxLength = 100;
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(148, 20);
            this.TxtBairro.TabIndex = 4;
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEndereco.Location = new System.Drawing.Point(56, 144);
            this.TxtEndereco.MaxLength = 100;
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(366, 20);
            this.TxtEndereco.TabIndex = 1;
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(56, 94);
            this.TxtNome.MaxLength = 100;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(545, 20);
            this.TxtNome.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(449, 311);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 15);
            this.label14.TabIndex = 100;
            this.label14.Text = "Data Nascimento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(259, 313);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 97;
            this.label13.Text = "CPF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(52, 356);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 15);
            this.label12.TabIndex = 95;
            this.label12.Text = "E-Mail";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(52, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 15);
            this.label11.TabIndex = 93;
            this.label11.Text = "RG";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(449, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 91;
            this.label10.Text = "Celular";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(240, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 15);
            this.label9.TabIndex = 89;
            this.label9.Text = "Telefone Comercial";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 87;
            this.label8.Text = "Telefone Fixo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 85;
            this.label7.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(450, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 84;
            this.label6.Text = "Cep";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 82;
            this.label5.Text = "Cidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(450, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 80;
            this.label4.Text = "Bairro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 78;
            this.label3.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 76;
            this.label2.Text = "Nome";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataCad);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.CboCadPor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtCodCliente);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MktCelular);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MktCPF);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MktCep);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.MkFoneComercial);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.MktFoneFixo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CmbEstado);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.CboSexo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dataNasc);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.BtnDeletar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.BtnAlterar);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.BtnConsultar);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Controls.Add(this.TxtEndereco);
            this.groupBox1.Controls.Add(this.BtnSair);
            this.groupBox1.Controls.Add(this.TxtBairro);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.TxtCidade);
            this.groupBox1.Controls.Add(this.BtnCadastrar);
            this.groupBox1.Controls.Add(this.TxtRG);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 462);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Cliente";
            // 
            // CboCadPor
            // 
            this.CboCadPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCadPor.FormattingEnabled = true;
            this.CboCadPor.ItemHeight = 13;
            this.CboCadPor.Location = new System.Drawing.Point(450, 372);
            this.CboCadPor.Name = "CboCadPor";
            this.CboCadPor.Size = new System.Drawing.Size(148, 21);
            this.CboCadPor.TabIndex = 14;
            this.CboCadPor.Text = "Selecione";
            this.CboCadPor.Click += new System.EventHandler(this.CboCadPor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 136;
            this.label1.Text = "Cadastrado Por";
            // 
            // TxtCodCliente
            // 
            this.TxtCodCliente.Enabled = false;
            this.TxtCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodCliente.Location = new System.Drawing.Point(56, 53);
            this.TxtCodCliente.MaxLength = 5;
            this.TxtCodCliente.Name = "TxtCodCliente";
            this.TxtCodCliente.Size = new System.Drawing.Size(77, 20);
            this.TxtCodCliente.TabIndex = 111;
            this.TxtCodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCodCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodCliente_KeyPress);
            this.TxtCodCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCodCliente_KeyUp);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(450, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 138;
            this.label15.Text = "Data Cadastro";
            // 
            // DataCad
            // 
            this.DataCad.CustomFormat = "dd/MM/yyyy";
            this.DataCad.Enabled = false;
            this.DataCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataCad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataCad.Location = new System.Drawing.Point(452, 55);
            this.DataCad.Name = "DataCad";
            this.DataCad.Size = new System.Drawing.Size(148, 20);
            this.DataCad.TabIndex = 139;
            // 
            // FrmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 523);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MktCelular;
        private System.Windows.Forms.MaskedTextBox MktCPF;
        private System.Windows.Forms.MaskedTextBox MktCep;
        private System.Windows.Forms.MaskedTextBox MkFoneComercial;
        private System.Windows.Forms.MaskedTextBox MktFoneFixo;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.ComboBox CboSexo;
        private System.Windows.Forms.DateTimePicker dataNasc;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtRG;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.TextBox TxtEndereco;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtCodCliente;
        private System.Windows.Forms.ComboBox CboCadPor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker DataCad;
    }
}