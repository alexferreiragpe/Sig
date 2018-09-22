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

namespace SGVB
{
    public partial class FrmEstoqueConsultar : Form
    {

        private SqlConnection conn = ConexaoBanco.sqlConnection;

        public FrmEstoqueConsultar()
        {
            InitializeComponent();
        }


        private void FrmEstoqueConsultar_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {

            var sqlDataAdapter = new SqlDataAdapter("select * from Produto", conn);
            var sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            var bindigSource = new BindingSource();
            bindigSource.DataSource = dataTable;
            dataGridView1.DataSource = bindigSource;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
