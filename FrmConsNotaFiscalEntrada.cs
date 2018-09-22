using System;
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
    public partial class FrmConsNotaFiscalEntrada : Form
    {

        private SqlConnection conn = SGVB.ConexaoBanco.sqlConnection;

        public FrmConsNotaFiscalEntrada()
        {
            InitializeComponent();
        }

        private void CarregaGrid()
        {

            var sqlDataAdapter = new SqlDataAdapter("select NotaFiscalNumero,TotalNota,DataLanc,DataVenc,Id_Fornecedor as Fornecedor,usuario as CadastradoPor from NotaFiscal inner join usuario on notafiscal.Id_usuario=Usuario.Id_usuario order by NotaFiscal",conn);
            var sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            var bindigSource = new BindingSource();
            bindigSource.DataSource = dataTable;
            dataGridView1.DataSource = bindigSource;

        }
        private void FrmConsNotaFiscalEntrada_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
