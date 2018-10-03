using System;
using System.Data;
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

            var sqlDataAdapter = new SqlDataAdapter("select NotaFiscalNumero,TotalNota,DataLanc,DataVenc,RazaoSocial as Fornecedor,usuario as Usuário from NotaFiscal NF inner join usuario on Nf.Id_usuario=Usuario.Id_usuario " +
                "inner join fornecedor F on Nf.id_fornecedor=F.Id_fornecedor order by DataLanc",conn);
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
