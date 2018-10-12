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

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Produto", conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            BindingSource bindigSource = new BindingSource
            {
                DataSource = dataTable
            };
            dataGridView1.DataSource = bindigSource;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
