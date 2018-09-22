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
    public partial class FrmConsProduto : Form
    {

        private SqlConnection conn = SGVB.ConexaoBanco.sqlConnection;

        public FrmConsProduto()
        {
            InitializeComponent();
        }
        private void CarregaGrid()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Id_Produto, Descricao, Qtd as Quant, EAN, Categoria, PrecoCompra as Preço_Compra, Lucro, PrecoVenda as Preço_Venda, SubCateg, EstoqueMin, EstoqueMax, Fabricante, ICMS, IPI, Unidade, Produto.DataCad as Data_Cadastro, usuario.usuario as CadastradoPor from Produto inner join usuario on Produto.id_usuario=usuario.id_usuario", conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            BindingSource bindigSource = new BindingSource
            {
                DataSource = dataTable
            };
            dataGridView1.DataSource = bindigSource;

        }

        private void FrmConsProduto_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }      
    }
}
