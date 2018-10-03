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
    public partial class FrmConsItemVenda : Form
    {

        private SqlConnection conn = SGVB.ConexaoBanco.sqlConnection;

        public FrmConsItemVenda()
        {
            InitializeComponent();
        }
        private void CarregaGrid()
        {


            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select distinct venda.Id_Venda,Id_Cliente as Cliente,Descricao,Valor_Unit as Valor_Unitário,Qtd as Quant,Total_Item as Total,DataVenda as Data_Venda,Id_Usuario as Usuário from VendaItens inner join venda on vendaItens.id_venda=venda.id_venda order by venda.Id_Venda",conn );
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            BindingSource bindigSource = new BindingSource
            {
                DataSource = dataTable
            };
            dataGridView1.DataSource = bindigSource;

        }

        private void FrmConsItemVenda_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

    }
}
