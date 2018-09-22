namespace SGVB
{
    partial class FrmVendaPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendaPedido));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtCodVenda = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CboFormaPag = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCodCliente = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnRemoveItem = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.TxtDescri = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCodProduto = new System.Windows.Forms.TextBox();
            this.TxtValorUnit = new System.Windows.Forms.TextBox();
            this.TxtQtde = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtEstoque = new System.Windows.Forms.TextBox();
            this.BtnAddProduto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.LblValorTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnFimCompra = new System.Windows.Forms.Button();
            this.BtnNovaCompra = new System.Windows.Forms.Button();
            this.BtnConsProduto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnLimpar);
            this.groupBox1.Controls.Add(this.BtnSair);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.LblValorTotal);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.BtnFimCompra);
            this.groupBox1.Controls.Add(this.BtnNovaCompra);
            this.groupBox1.Controls.Add(this.BtnConsProduto);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(867, 616);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venda";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(479, 556);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(87, 38);
            this.BtnLimpar.TabIndex = 28;
            this.BtnLimpar.Text = "Cancelar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(572, 556);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 38);
            this.BtnSair.TabIndex = 27;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtCodVenda);
            this.groupBox3.Controls.Add(this.TxtNome);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.CboFormaPag);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.TxtCodCliente);
            this.groupBox3.Location = new System.Drawing.Point(34, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 215);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados da Venda";
            // 
            // TxtCodVenda
            // 
            this.TxtCodVenda.Enabled = false;
            this.TxtCodVenda.Location = new System.Drawing.Point(102, 31);
            this.TxtCodVenda.Name = "TxtCodVenda";
            this.TxtCodVenda.Size = new System.Drawing.Size(63, 22);
            this.TxtCodVenda.TabIndex = 19;
            this.TxtCodVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtNome
            // 
            this.TxtNome.Enabled = false;
            this.TxtNome.Location = new System.Drawing.Point(97, 121);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(287, 22);
            this.TxtNome.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(14, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(370, 52);
            this.listBox1.TabIndex = 11;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Forma Pag";
            // 
            // CboFormaPag
            // 
            this.CboFormaPag.Enabled = false;
            this.CboFormaPag.FormattingEnabled = true;
            this.CboFormaPag.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão",
            "Cheque",
            "Parcelado 2X",
            "Parcelado 3X"});
            this.CboFormaPag.Location = new System.Drawing.Point(97, 177);
            this.CboFormaPag.Name = "CboFormaPag";
            this.CboFormaPag.Size = new System.Drawing.Size(287, 24);
            this.CboFormaPag.TabIndex = 10;
            this.CboFormaPag.Text = "Selecione";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cód Venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cliente";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(273, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cód Cliente";
            // 
            // TxtCodCliente
            // 
            this.TxtCodCliente.Enabled = false;
            this.TxtCodCliente.Location = new System.Drawing.Point(97, 149);
            this.TxtCodCliente.Name = "TxtCodCliente";
            this.TxtCodCliente.Size = new System.Drawing.Size(111, 22);
            this.TxtCodCliente.TabIndex = 6;
            this.TxtCodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnRemoveItem);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.TxtDescri);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtCodProduto);
            this.groupBox2.Controls.Add(this.TxtValorUnit);
            this.groupBox2.Controls.Add(this.TxtQtde);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtEstoque);
            this.groupBox2.Controls.Add(this.BtnAddProduto);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(442, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 215);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Produto";
            // 
            // BtnRemoveItem
            // 
            this.BtnRemoveItem.Enabled = false;
            this.BtnRemoveItem.Location = new System.Drawing.Point(268, 181);
            this.BtnRemoveItem.Name = "BtnRemoveItem";
            this.BtnRemoveItem.Size = new System.Drawing.Size(131, 28);
            this.BtnRemoveItem.TabIndex = 23;
            this.BtnRemoveItem.Text = "Remover Item";
            this.BtnRemoveItem.UseVisualStyleBackColor = true;
            this.BtnRemoveItem.Click += new System.EventHandler(this.BtnRemoveItem_Click);
            // 
            // listBox2
            // 
            this.listBox2.Enabled = false;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(12, 19);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(387, 68);
            this.listBox2.TabIndex = 22;
            this.listBox2.Click += new System.EventHandler(this.listBox2_Click);
            // 
            // TxtDescri
            // 
            this.TxtDescri.Enabled = false;
            this.TxtDescri.Location = new System.Drawing.Point(84, 91);
            this.TxtDescri.Name = "TxtDescri";
            this.TxtDescri.Size = new System.Drawing.Size(315, 22);
            this.TxtDescri.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Descrição";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Código";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Qtde";
            // 
            // TxtCodProduto
            // 
            this.TxtCodProduto.Enabled = false;
            this.TxtCodProduto.Location = new System.Drawing.Point(67, 119);
            this.TxtCodProduto.Name = "TxtCodProduto";
            this.TxtCodProduto.Size = new System.Drawing.Size(172, 22);
            this.TxtCodProduto.TabIndex = 13;
            // 
            // TxtValorUnit
            // 
            this.TxtValorUnit.Enabled = false;
            this.TxtValorUnit.Location = new System.Drawing.Point(285, 147);
            this.TxtValorUnit.Name = "TxtValorUnit";
            this.TxtValorUnit.Size = new System.Drawing.Size(113, 22);
            this.TxtValorUnit.TabIndex = 15;
            this.TxtValorUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtQtde
            // 
            this.TxtQtde.Enabled = false;
            this.TxtQtde.Location = new System.Drawing.Point(56, 147);
            this.TxtQtde.Name = "TxtQtde";
            this.TxtQtde.Size = new System.Drawing.Size(79, 22);
            this.TxtQtde.TabIndex = 16;
            this.TxtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQtde_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Valor Unit";
            // 
            // TxtEstoque
            // 
            this.TxtEstoque.Enabled = false;
            this.TxtEstoque.Location = new System.Drawing.Point(336, 119);
            this.TxtEstoque.Name = "TxtEstoque";
            this.TxtEstoque.Size = new System.Drawing.Size(62, 22);
            this.TxtEstoque.TabIndex = 18;
            this.TxtEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnAddProduto
            // 
            this.BtnAddProduto.Enabled = false;
            this.BtnAddProduto.Location = new System.Drawing.Point(12, 181);
            this.BtnAddProduto.Name = "BtnAddProduto";
            this.BtnAddProduto.Size = new System.Drawing.Size(183, 28);
            this.BtnAddProduto.TabIndex = 20;
            this.BtnAddProduto.Text = "Adicionar Item";
            this.BtnAddProduto.UseVisualStyleBackColor = true;
            this.BtnAddProduto.Click += new System.EventHandler(this.BtnAddProduto_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Estoque";
            // 
            // LblValorTotal
            // 
            this.LblValorTotal.BackColor = System.Drawing.Color.Lime;
            this.LblValorTotal.Location = new System.Drawing.Point(724, 573);
            this.LblValorTotal.Name = "LblValorTotal";
            this.LblValorTotal.Size = new System.Drawing.Size(110, 21);
            this.LblValorTotal.TabIndex = 24;
            this.LblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(724, 551);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Valor Total";
            // 
            // BtnFimCompra
            // 
            this.BtnFimCompra.Enabled = false;
            this.BtnFimCompra.Location = new System.Drawing.Point(324, 556);
            this.BtnFimCompra.Name = "BtnFimCompra";
            this.BtnFimCompra.Size = new System.Drawing.Size(149, 38);
            this.BtnFimCompra.TabIndex = 22;
            this.BtnFimCompra.Text = "Finalizar Venda";
            this.BtnFimCompra.UseVisualStyleBackColor = true;
            this.BtnFimCompra.Click += new System.EventHandler(this.BtnFimCompra_Click);
            // 
            // BtnNovaCompra
            // 
            this.BtnNovaCompra.Location = new System.Drawing.Point(34, 556);
            this.BtnNovaCompra.Name = "BtnNovaCompra";
            this.BtnNovaCompra.Size = new System.Drawing.Size(129, 38);
            this.BtnNovaCompra.TabIndex = 21;
            this.BtnNovaCompra.Text = "Nova Venda";
            this.BtnNovaCompra.UseVisualStyleBackColor = true;
            this.BtnNovaCompra.Click += new System.EventHandler(this.BtnNovaCompra_Click);
            // 
            // BtnConsProduto
            // 
            this.BtnConsProduto.Location = new System.Drawing.Point(169, 556);
            this.BtnConsProduto.Name = "BtnConsProduto";
            this.BtnConsProduto.Size = new System.Drawing.Size(149, 38);
            this.BtnConsProduto.TabIndex = 19;
            this.BtnConsProduto.Text = "Consultar Produto";
            this.BtnConsProduto.UseVisualStyleBackColor = true;
            this.BtnConsProduto.Click += new System.EventHandler(this.BtnConsProduto_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descricao,
            this.Valor_Unit,
            this.Qtde,
            this.Total_Item});
            this.dataGridView1.Location = new System.Drawing.Point(34, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(816, 278);
            this.dataGridView1.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 83;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 104;
            // 
            // Valor_Unit
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Valor_Unit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Valor_Unit.HeaderText = "Valor_Unit";
            this.Valor_Unit.Name = "Valor_Unit";
            this.Valor_Unit.ReadOnly = true;
            // 
            // Qtde
            // 
            this.Qtde.HeaderText = "Qtde";
            this.Qtde.Name = "Qtde";
            this.Qtde.ReadOnly = true;
            // 
            // Total_Item
            // 
            this.Total_Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Total_Item.DefaultCellStyle = dataGridViewCellStyle2;
            this.Total_Item.HeaderText = "Total_Item";
            this.Total_Item.Name = "Total_Item";
            this.Total_Item.ReadOnly = true;
            this.Total_Item.Width = 106;
            // 
            // FrmVendaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(918, 640);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVendaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIG - Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TxtCodCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAddProduto;
        private System.Windows.Forms.Button BtnConsProduto;
        private System.Windows.Forms.TextBox TxtEstoque;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtQtde;
        private System.Windows.Forms.TextBox TxtValorUnit;
        private System.Windows.Forms.TextBox TxtCodProduto;
        private System.Windows.Forms.Button BtnFimCompra;
        private System.Windows.Forms.Button BtnNovaCompra;
        private System.Windows.Forms.Label LblValorTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CboFormaPag;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox TxtDescri;
        private System.Windows.Forms.Button BtnRemoveItem;
        private System.Windows.Forms.TextBox TxtCodVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Item;
    }
}