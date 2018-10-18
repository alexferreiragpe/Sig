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
    public partial class FrmEsqueciSenha : Form
        
    {

        private SqlConnection sqlConn = SIG.ConexaoBanco.sqlConnection;

        public FrmEsqueciSenha()
        {
            InitializeComponent();
        }

        private void BtnRecuperarLogin_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text == "")
            {
                MessageBox.Show("Preencher Nome Completo!");
                TxtNome.Focus();
            }
            else if (TxtUsuario.Text == "")
            {
                MessageBox.Show("Preencher Usuário!");
                TxtUsuario.Focus();
            }
            else if (TxtEmail.Text == "")
            {
                MessageBox.Show("Preencher E-mail!");
                TxtEmail.Focus();
            }            
            else 
            {
               
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
