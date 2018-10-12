namespace SGVB
{
    partial class FrmCompraPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompraPedido));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbCadPor = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnRemoverItem = new System.Windows.Forms.Button();
            this.LblTotalParcial = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CboFornecedor = new System.Windows.Forms.ComboBox();
            this.TxtTotalNota = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DataVencNF = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtEAN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnConsultaProduto = new System.Windows.Forms.Button();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtProduto = new System.Windows.Forms.TextBox();
            this.TxtFabricante = new System.Windows.Forms.TextBox();
            this.TxtPrecoCusto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtQuant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnFechaNota = new System.Windows.Forms.Button();
            this.BtnInserirProduto = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.Id_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNotaFiscal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbCadPor);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.BtnRemoverItem);
            this.groupBox1.Controls.Add(this.LblTotalParcial);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.BtnLimpar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CboFornecedor);
            this.groupBox1.Controls.Add(this.TxtTotalNota);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DataVencNF);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.BtnSair);
            this.groupBox1.Controls.Add(this.BtnDeletar);
            this.groupBox1.Controls.Add(this.BtnConsultar);
            this.groupBox1.Controls.Add(this.BtnFechaNota);
            this.groupBox1.Controls.Add(this.BtnInserirProduto);
            this.groupBox1.Controls.Add(this.dgvProdutos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtNotaFiscal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(49, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 603);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lançamento de Nota Fiscal";
            // 
            // CmbCadPor
            // 
            this.CmbCadPor.FormattingEnabled = true;
            this.CmbCadPor.Location = new System.Drawing.Point(333, 41);
            this.CmbCadPor.Name = "CmbCadPor";
            this.CmbCadPor.Size = new System.Drawing.Size(147, 24);
            this.CmbCadPor.TabIndex = 1;
            this.CmbCadPor.Text = "Selecione";
            this.CmbCadPor.Click += new System.EventHandler(this.CmbCadPor_Click);
            this.CmbCadPor.Enter += new System.EventHandler(this.CmbCadPor_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(267, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 17);
            this.label12.TabIndex = 71;
            this.label12.Text = "Usuário:";
            // 
            // BtnRemoverItem
            // 
            this.BtnRemoverItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoverItem.Location = new System.Drawing.Point(506, 272);
            this.BtnRemoverItem.Name = "BtnRemoverItem";
            this.BtnRemoverItem.Size = new System.Drawing.Size(220, 39);
            this.BtnRemoverItem.TabIndex = 11;
            this.BtnRemoverItem.Text = "Remover Produto";
            this.BtnRemoverItem.UseVisualStyleBackColor = true;
            this.BtnRemoverItem.Click += new System.EventHandler(this.BtnRemoverItem_Click);
            // 
            // LblTotalParcial
            // 
            this.LblTotalParcial.AutoSize = true;
            this.LblTotalParcial.Location = new System.Drawing.Point(613, 527);
            this.LblTotalParcial.Name = "LblTotalParcial";
            this.LblTotalParcial.Size = new System.Drawing.Size(0, 17);
            this.LblTotalParcial.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(500, 527);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 67;
            this.label8.Text = "Total Parcial";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(515, 558);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(100, 31);
            this.BtnLimpar.TabIndex = 15;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Fornecedor";
            // 
            // CboFornecedor
            // 
            this.CboFornecedor.FormattingEnabled = true;
            this.CboFornecedor.Location = new System.Drawing.Point(145, 83);
            this.CboFornecedor.Name = "CboFornecedor";
            this.CboFornecedor.Size = new System.Drawing.Size(335, 24);
            this.CboFornecedor.TabIndex = 3;
            this.CboFornecedor.Text = "Selecione";
            this.CboFornecedor.Click += new System.EventHandler(this.CboFornecedor_Click);
            this.CboFornecedor.Enter += new System.EventHandler(this.CboFornecedor_Enter);
            // 
            // TxtTotalNota
            // 
            this.TxtTotalNota.Location = new System.Drawing.Point(589, 81);
            this.TxtTotalNota.Name = "TxtTotalNota";
            this.TxtTotalNota.Size = new System.Drawing.Size(137, 23);
            this.TxtTotalNota.TabIndex = 4;
            this.TxtTotalNota.Text = "R$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(497, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Total Nota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(500, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Data Venc.";
            // 
            // DataVencNF
            // 
            this.DataVencNF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataVencNF.Location = new System.Drawing.Point(589, 40);
            this.DataVencNF.Name = "DataVencNF";
            this.DataVencNF.Size = new System.Drawing.Size(137, 23);
            this.DataVencNF.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.TxtEAN);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.BtnConsultaProduto);
            this.groupBox2.Controls.Add(this.TxtDescricao);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TxtProduto);
            this.groupBox2.Controls.Add(this.TxtFabricante);
            this.groupBox2.Controls.Add(this.TxtPrecoCusto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtQuant);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(22, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(704, 153);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Produto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(398, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 178;
            this.label11.Text = "Fabricante";
            // 
            // TxtEAN
            // 
            this.TxtEAN.Enabled = false;
            this.TxtEAN.Location = new System.Drawing.Point(484, 81);
            this.TxtEAN.Name = "TxtEAN";
            this.TxtEAN.Size = new System.Drawing.Size(213, 23);
            this.TxtEAN.TabIndex = 177;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(436, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 176;
            this.label10.Text = "EAN";
            // 
            // BtnConsultaProduto
            // 
            this.BtnConsultaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultaProduto.Location = new System.Drawing.Point(245, 36);
            this.BtnConsultaProduto.Name = "BtnConsultaProduto";
            this.BtnConsultaProduto.Size = new System.Drawing.Size(176, 31);
            this.BtnConsultaProduto.TabIndex = 7;
            this.BtnConsultaProduto.Text = "Consultar Produtos";
            this.BtnConsultaProduto.UseVisualStyleBackColor = true;
            this.BtnConsultaProduto.Click += new System.EventHandler(this.BtnConsultaProduto_Click);
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Enabled = false;
            this.TxtDescricao.Location = new System.Drawing.Point(103, 81);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(318, 23);
            this.TxtDescricao.TabIndex = 174;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 173;
            this.label9.Text = "Descrição";
            // 
            // TxtProduto
            // 
            this.TxtProduto.Location = new System.Drawing.Point(103, 40);
            this.TxtProduto.Name = "TxtProduto";
            this.TxtProduto.Size = new System.Drawing.Size(116, 23);
            this.TxtProduto.TabIndex = 6;
            this.TxtProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProduto_KeyPress);
            this.TxtProduto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtProduto_KeyUp);
            // 
            // TxtFabricante
            // 
            this.TxtFabricante.Enabled = false;
            this.TxtFabricante.Location = new System.Drawing.Point(484, 123);
            this.TxtFabricante.Name = "TxtFabricante";
            this.TxtFabricante.Size = new System.Drawing.Size(213, 23);
            this.TxtFabricante.TabIndex = 171;
            // 
            // TxtPrecoCusto
            // 
            this.TxtPrecoCusto.Location = new System.Drawing.Point(103, 123);
            this.TxtPrecoCusto.Name = "TxtPrecoCusto";
            this.TxtPrecoCusto.Size = new System.Drawing.Size(116, 23);
            this.TxtPrecoCusto.TabIndex = 8;
            this.TxtPrecoCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 170;
            this.label5.Text = "Preço Custo";
            // 
            // TxtQuant
            // 
            this.TxtQuant.Location = new System.Drawing.Point(332, 123);
            this.TxtQuant.Name = "TxtQuant";
            this.TxtQuant.Size = new System.Drawing.Size(49, 23);
            this.TxtQuant.TabIndex = 9;
            this.TxtQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtQuant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQuant_KeyPress_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 160;
            this.label4.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 155;
            this.label3.Text = "Id Produto";
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(649, 558);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(77, 31);
            this.BtnSair.TabIndex = 16;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click_1);
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.Enabled = false;
            this.BtnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeletar.Location = new System.Drawing.Point(368, 558);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(100, 31);
            this.BtnDeletar.TabIndex = 14;
            this.BtnDeletar.Text = "Deletar";
            this.BtnDeletar.UseVisualStyleBackColor = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.Location = new System.Drawing.Point(221, 558);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(106, 31);
            this.BtnConsultar.TabIndex = 13;
            this.BtnConsultar.Text = "Consultar NF";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnFechaNota
            // 
            this.BtnFechaNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFechaNota.Location = new System.Drawing.Point(22, 558);
            this.BtnFechaNota.Name = "BtnFechaNota";
            this.BtnFechaNota.Size = new System.Drawing.Size(166, 31);
            this.BtnFechaNota.TabIndex = 12;
            this.BtnFechaNota.Text = "Fechar Nota Fiscal";
            this.BtnFechaNota.UseVisualStyleBackColor = true;
            this.BtnFechaNota.Click += new System.EventHandler(this.BtnFechaNota_Click);
            // 
            // BtnInserirProduto
            // 
            this.BtnInserirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInserirProduto.Location = new System.Drawing.Point(22, 272);
            this.BtnInserirProduto.Name = "BtnInserirProduto";
            this.BtnInserirProduto.Size = new System.Drawing.Size(421, 39);
            this.BtnInserirProduto.TabIndex = 10;
            this.BtnInserirProduto.Text = "Inserir Produto";
            this.BtnInserirProduto.UseVisualStyleBackColor = true;
            this.BtnInserirProduto.Click += new System.EventHandler(this.BtnInserirProduto_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToOrderColumns = true;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Produto,
            this.Ean,
            this.Descricao,
            this.PrecoUnitario,
            this.Qtde,
            this.TotalItem,
            this.Fabricante});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.Location = new System.Drawing.Point(21, 317);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvProdutos.Size = new System.Drawing.Size(803, 207);
            this.dgvProdutos.TabIndex = 49;
            // 
            // Id_Produto
            // 
            this.Id_Produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id_Produto.HeaderText = "Id_Produto";
            this.Id_Produto.Name = "Id_Produto";
            this.Id_Produto.ReadOnly = true;
            this.Id_Produto.Width = 112;
            // 
            // Ean
            // 
            this.Ean.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ean.HeaderText = "Ean";
            this.Ean.Name = "Ean";
            this.Ean.ReadOnly = true;
            this.Ean.Width = 61;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 105;
            // 
            // PrecoUnitario
            // 
            this.PrecoUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.PrecoUnitario.DefaultCellStyle = dataGridViewCellStyle1;
            this.PrecoUnitario.HeaderText = "Preco Custo";
            this.PrecoUnitario.Name = "PrecoUnitario";
            this.PrecoUnitario.ReadOnly = true;
            this.PrecoUnitario.Width = 121;
            // 
            // Qtde
            // 
            this.Qtde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Qtde.HeaderText = "Qtde";
            this.Qtde.Name = "Qtde";
            this.Qtde.ReadOnly = true;
            this.Qtde.Width = 68;
            // 
            // TotalItem
            // 
            this.TotalItem.HeaderText = "Total Item";
            this.TotalItem.Name = "TotalItem";
            this.TotalItem.ReadOnly = true;
            this.TotalItem.Width = 105;
            // 
            // Fabricante
            // 
            this.Fabricante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fabricante.HeaderText = "Fabricante";
            this.Fabricante.Name = "Fabricante";
            this.Fabricante.ReadOnly = true;
            this.Fabricante.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 65;
            this.label1.Text = "Nota Fiscal Nº";
            // 
            // TxtNotaFiscal
            // 
            this.TxtNotaFiscal.Location = new System.Drawing.Point(145, 42);
            this.TxtNotaFiscal.Name = "TxtNotaFiscal";
            this.TxtNotaFiscal.Size = new System.Drawing.Size(116, 23);
            this.TxtNotaFiscal.TabIndex = 0;
            this.TxtNotaFiscal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNotaFiscal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNotaFiscal_KeyPress);
            this.TxtNotaFiscal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtNotaFiscal_KeyUp);
            // 
            // FrmCompraPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(891, 653);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCompraPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIG - Compras - Pedido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNotaFiscal;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnFechaNota;
        private System.Windows.Forms.Button BtnInserirProduto;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtPrecoCusto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtQuant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTotalNota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DataVencNF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboFornecedor;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Label LblTotalParcial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnRemoverItem;
        private System.Windows.Forms.TextBox TxtFabricante;
        private System.Windows.Forms.Button BtnConsultaProduto;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtProduto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtEAN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CmbCadPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ean;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fabricante;
    }
}