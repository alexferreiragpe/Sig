using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIG
{
    public partial class FrmConsNotaEntrada : Form
    {

        private SqlConnection conn = SGVB.ConexaoBanco.sqlConnection;

        public FrmConsNotaEntrada()
        {
            InitializeComponent();
        }
        private void CarregaGrid()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select NotaFiscalNumero,TotalNota,DataLanc,DataVenc,Id_fornecedor as Fornecedor,Id_usuario as Usuário from NotaFiscal", conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            BindingSource bindigSource = new BindingSource
            {
                DataSource = dataTable
            };
            dataGridView1.DataSource = bindigSource;

        }

        private void FrmConsNotaEntrada_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
