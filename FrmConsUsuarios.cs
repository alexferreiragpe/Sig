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
    public partial class FrmConsultaUsuarios : Form
    {
        public FrmConsultaUsuarios()
        {
            InitializeComponent();
        }
        private SqlConnection conn = SGVB.ConexaoBanco.sqlConnection;

        private void CarregaGrid()
        {
            var sqlDataAdapter = new SqlDataAdapter("select Id_Usuario,Usuario as Nome_Usuário,Nome as Nome_Completo,Email as Email,Tipo,id_user as CadastradoPor,DataCad as DataCadastro from usuario", conn);
            var sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            var bindigSource = new BindingSource
            {
                DataSource = dataTable
            };
            DGVConsUsuarios.DataSource = bindigSource;

        }

        private void FrConsultaUsuarios_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

       }
}
