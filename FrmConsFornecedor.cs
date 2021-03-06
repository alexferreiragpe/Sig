﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SGDB
{
    public partial class FrmConsFornecedor : Form
    {

        private SqlConnection conn = SIG.ConexaoBanco.sqlConnection;

        public FrmConsFornecedor()
        {
            InitializeComponent();
        }
        private void CarregaGrid()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Id_Fornecedor, RazaoSocial, CNPJ, NomeFantasia, IE, Endereco, TipoPessoa, Cidade, Bairro, Estado, Cep, FoneFixo, FoneComercial, Celular, Site, Fornecedor.Email, Fornecedor.DataCad as DataCadastro,Usuario as CadastradoPor from Fornecedor inner join usuario on fornecedor.id_usuario=usuario.id_usuario", conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            BindingSource bindigSource = new BindingSource
            {
                DataSource = dataTable
            };
            dataGridView1.DataSource = bindigSource;
        }

        private void FrmConsFornecedor_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

    }
}
