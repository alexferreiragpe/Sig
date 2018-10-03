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
    public partial class FrmConsClientes : Form
    {

        private SqlConnection conn = SGVB.ConexaoBanco.sqlConnection;

        public FrmConsClientes()
        {
            InitializeComponent();
        }

        private void CarregaGrid()
        {
            var sqlDataAdapter = new SqlDataAdapter("select Id_Cliente, Clientes.Nome, Sexo, Endereco, Bairro, Cidade, Cep, Estado, FoneFixo, FoneComercial, Celular, RG, Clientes.Email, CPF, DataNascimento,Clientes.DataCad as Data_Cadastro,usuario.usuario as CadastradoPor from Clientes inner join usuario on clientes.id_usuario=usuario.id_usuario", conn);
            var sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            var bindigSource = new BindingSource
            {
                DataSource = dataTable
            };
            dataGridView1.DataSource = bindigSource;

        }

        private void FrmConsClientes_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
