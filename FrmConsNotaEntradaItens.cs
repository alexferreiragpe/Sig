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

namespace SIG
{
    public partial class FrmCompraOrcamento : Form
    {

        private SqlConnection conn = ConexaoBanco.sqlConnection;

        public FrmCompraOrcamento()
        {
            InitializeComponent();
        }

        private void CarregaGrid()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select distinct NotaFiscalNumero as Nota_Fiscal,Id_Produto,Descricao,Qtd,PrecoUnitario as Preço_Unitário,Id_Fornecedor as Fornecedor,dataLanc as Data_Lanc from NotaFiscal inner join NotaFiscalItens on NotaFiscal.NotaFiscalNumero=NotaFiscalItens.NFNumero order by NotaFiscal.NotaFiscalNumero", conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            BindingSource bindigSource = new BindingSource
            {
                DataSource = dataTable
            };
            dataGridView1.DataSource = bindigSource;
        }
        private void FrmCompraOrcamento_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

    }
}
